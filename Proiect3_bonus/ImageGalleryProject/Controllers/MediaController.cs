using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImageGalleryProject.Infrastructure;
using ImageGalleryProject.Models;
using ImageGalleryProject.ViewModels.MediaViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageGalleryProject.Controllers
{
    public class MediaController : Controller
    {
        // GET: MediaManager
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MediaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var media = _unitOfWork.MediaRepo.GetAll();
            var vm = _mapper.Map<List<MediaViewModel>>(media);
            return View(vm);
        }

        // GET: MediaManager/Details/5
        public ActionResult Details(int id)
        {
            var media = _unitOfWork.MediaRepo.GetById(id);
            var vm = _mapper.Map<MediaViewModel>(media);
            return View(vm);
        }

        // GET: MediaManager/Create
        public ActionResult Create()
        {
            ViewBag.Categories = _unitOfWork.CategoryRepo.GetAll();
            return View();
        }

        // POST: MediaManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MediaCreateViewModel vm)
        {
            try
            {
                var category = _unitOfWork.CategoryRepo.GetById(vm.CategoryId);

                List<Media> media = new List<Media>();
                foreach (var file in vm.Files)
                {
                    media.Add(new Media()
                    {
                        ImagePath = file.FileName,
                        Category = category
                    });
                }

                _unitOfWork.UploadFile(vm.Files);
                _unitOfWork.MediaRepo.AddRange(media);
                _unitOfWork.Save();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaManager/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Categories = _unitOfWork.CategoryRepo.GetAll();
            var media = _unitOfWork.MediaRepo.GetById(id);
            var mappedMedia = _mapper.Map<MediaEditViewModel>(media);

            return View(mappedMedia);
        }

        // POST: MediaManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MediaEditViewModel vm)
        {
            try
            {
                if (vm.File == null && _unitOfWork.MediaRepo.GetById(vm.Id).CategoryId == vm.CategoryId)
                {
                    RedirectToAction(nameof(Index));
                }
                else if (vm.File != null)
                {
                    List<IFormFile> files = new List<IFormFile>();
                    files.Add(vm.File);
                    var updateMedia = _unitOfWork.MediaRepo.GetById(vm.Id);
                    updateMedia.CategoryId = vm.CategoryId;
                    updateMedia.ImagePath = vm.File.FileName;

                    _unitOfWork.UploadFile(files);
                    _unitOfWork.MediaRepo.Update(updateMedia);
                    _unitOfWork.Save();
                    RedirectToAction(nameof(Index));
                }
                else if (_unitOfWork.MediaRepo.GetById(vm.Id).CategoryId != vm.CategoryId)
                {
                    List<IFormFile> files = new List<IFormFile>();
                    files.Add(vm.File);
                    var updateMedia = _unitOfWork.MediaRepo.GetById(vm.Id);
                    updateMedia.CategoryId = vm.CategoryId;
                    updateMedia.ImagePath = _unitOfWork.MediaRepo.GetById(vm.Id).ImagePath;

                    // _unitOfWork.UploadFile(files);
                    _unitOfWork.MediaRepo.Update(updateMedia);
                    _unitOfWork.Save();
                    RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaManager/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _unitOfWork.MediaRepo.GetById(id);
            var vm = _mapper.Map<MediaViewModel>(model);

            return View(vm);
        }

        // POST: MediaManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
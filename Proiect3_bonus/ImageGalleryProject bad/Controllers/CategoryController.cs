using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ImageGalleryProject.Infrastructure;
using ImageGalleryProject.Models;
using ImageGalleryProject.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ImageGalleryProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: Category
        public IActionResult Index()
        {
            var categories = _unitOfWork.CategoryRepo.GetAll();
            var mappedCategories = _mapper.Map<List<CategoryViewModel>>(categories);
            return View(mappedCategories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var category = _unitOfWork.CategoryRepo.GetById(id);
            var mappedCategory = _mapper.Map<CategoryViewModel>(category);
            return View(mappedCategory);
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCategoryViewModel category)
        {
            try
            {
                var mappedCategory = _mapper.Map<Category>(category);
                _unitOfWork.CategoryRepo.Insert(mappedCategory);
                _unitOfWork.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            var category = _unitOfWork.CategoryRepo.GetById(id);
            var mappedCategory = _mapper.Map<EditCategoryViewModel>(category);
            return View(mappedCategory);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditCategoryViewModel vm)
        {
            try
            {
                var category = _mapper.Map<Category>(vm);
                _unitOfWork.CategoryRepo.Update(category);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var category = _unitOfWork.CategoryRepo.GetById(id);
            var mappedCategory = _mapper.Map<CategoryViewModel>(category);
            return View(mappedCategory);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int Id, CategoryViewModel category)
        {
            try
            {
                _unitOfWork.CategoryRepo.Delete(Id);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
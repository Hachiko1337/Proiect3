﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceProiect3
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MetadataDTO", Namespace="http://schemas.datacontract.org/2004/07/Proiect2ObjectWCF", IsReference=true)]
    public partial class MetadataDTO : object
    {
        
        private System.DateTime CreatedAtField;
        
        private string FIleTypeField;
        
        private ServiceReferenceProiect3.FileDTO FileField;
        
        private int FileIDField;
        
        private int IdField;
        
        private bool IsDeletedField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedAt
        {
            get
            {
                return this.CreatedAtField;
            }
            set
            {
                this.CreatedAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FIleType
        {
            get
            {
                return this.FIleTypeField;
            }
            set
            {
                this.FIleTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceProiect3.FileDTO File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FileID
        {
            get
            {
                return this.FileIDField;
            }
            set
            {
                this.FileIDField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsDeleted
        {
            get
            {
                return this.IsDeletedField;
            }
            set
            {
                this.IsDeletedField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileDTO", Namespace="http://schemas.datacontract.org/2004/07/Proiect2ObjectWCF", IsReference=true)]
    public partial class FileDTO : object
    {
        
        private string FilePathField;
        
        private int IdField;
        
        private ServiceReferenceProiect3.MetadataDTO MetadataField;
        
        private System.Collections.Generic.List<ServiceReferenceProiect3.PropertyDTO> PropertiesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FilePath
        {
            get
            {
                return this.FilePathField;
            }
            set
            {
                this.FilePathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceProiect3.MetadataDTO Metadata
        {
            get
            {
                return this.MetadataField;
            }
            set
            {
                this.MetadataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceProiect3.PropertyDTO> Properties
        {
            get
            {
                return this.PropertiesField;
            }
            set
            {
                this.PropertiesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PropertyDTO", Namespace="http://schemas.datacontract.org/2004/07/Proiect2ObjectWCF", IsReference=true)]
    public partial class PropertyDTO : object
    {
        
        private string EventNameField;
        
        private ServiceReferenceProiect3.FileDTO FileField;
        
        private int FileId1Field;
        
        private int IdField;
        
        private string LandscapeNameField;
        
        private string PersonNameField;
        
        private string PlaceNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EventName
        {
            get
            {
                return this.EventNameField;
            }
            set
            {
                this.EventNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceProiect3.FileDTO File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FileId1
        {
            get
            {
                return this.FileId1Field;
            }
            set
            {
                this.FileId1Field = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LandscapeName
        {
            get
            {
                return this.LandscapeNameField;
            }
            set
            {
                this.LandscapeNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PersonName
        {
            get
            {
                return this.PersonNameField;
            }
            set
            {
                this.PersonNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlaceName
        {
            get
            {
                return this.PlaceNameField;
            }
            set
            {
                this.PlaceNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceProiect3.IFileMetadataProperty")]
    public interface IFileMetadataProperty
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetadata/GetAllMedata", ReplyAction="http://tempuri.org/IMetadata/GetAllMedataResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.MetadataDTO>> GetAllMedataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/SaveFile", ReplyAction="http://tempuri.org/IFile/SaveFileResponse")]
        System.Threading.Tasks.Task SaveFileAsync(ServiceReferenceProiect3.FileDTO file);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/GetAllFiles", ReplyAction="http://tempuri.org/IFile/GetAllFilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.FileDTO>> GetAllFilesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/FileFilter", ReplyAction="http://tempuri.org/IFile/FileFilterResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.FileDTO>> FileFilterAsync(string condition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFile/DeleteFile", ReplyAction="http://tempuri.org/IFile/DeleteFileResponse")]
        System.Threading.Tasks.Task DeleteFileAsync(ServiceReferenceProiect3.FileDTO file);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProperties/GetAllProperties", ReplyAction="http://tempuri.org/IProperties/GetAllPropertiesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.PropertyDTO>> GetAllPropertiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProperties/AddProperty", ReplyAction="http://tempuri.org/IProperties/AddPropertyResponse")]
        System.Threading.Tasks.Task AddPropertyAsync(ServiceReferenceProiect3.PropertyDTO property);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IFileMetadataPropertyChannel : ServiceReferenceProiect3.IFileMetadataProperty, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class FileMetadataPropertyClient : System.ServiceModel.ClientBase<ServiceReferenceProiect3.IFileMetadataProperty>, ServiceReferenceProiect3.IFileMetadataProperty
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public FileMetadataPropertyClient() : 
                base(FileMetadataPropertyClient.GetDefaultBinding(), FileMetadataPropertyClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IFileMetadataProperty.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileMetadataPropertyClient(EndpointConfiguration endpointConfiguration) : 
                base(FileMetadataPropertyClient.GetBindingForEndpoint(endpointConfiguration), FileMetadataPropertyClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileMetadataPropertyClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(FileMetadataPropertyClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileMetadataPropertyClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(FileMetadataPropertyClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public FileMetadataPropertyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.MetadataDTO>> GetAllMedataAsync()
        {
            return base.Channel.GetAllMedataAsync();
        }
        
        public System.Threading.Tasks.Task SaveFileAsync(ServiceReferenceProiect3.FileDTO file)
        {
            return base.Channel.SaveFileAsync(file);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.FileDTO>> GetAllFilesAsync()
        {
            return base.Channel.GetAllFilesAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.FileDTO>> FileFilterAsync(string condition)
        {
            return base.Channel.FileFilterAsync(condition);
        }
        
        public System.Threading.Tasks.Task DeleteFileAsync(ServiceReferenceProiect3.FileDTO file)
        {
            return base.Channel.DeleteFileAsync(file);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceProiect3.PropertyDTO>> GetAllPropertiesAsync()
        {
            return base.Channel.GetAllPropertiesAsync();
        }
        
        public System.Threading.Tasks.Task AddPropertyAsync(ServiceReferenceProiect3.PropertyDTO property)
        {
            return base.Channel.AddPropertyAsync(property);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFileMetadataProperty))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IFileMetadataProperty))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return FileMetadataPropertyClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IFileMetadataProperty);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return FileMetadataPropertyClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IFileMetadataProperty);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IFileMetadataProperty,
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Startup.DiskServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDto", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.DataTransferObjects")]
    [System.SerializableAttribute()]
    public partial class UserDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HashedPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HashedPassword {
            get {
                return this.HashedPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.HashedPasswordField, value) != true)) {
                    this.HashedPasswordField = value;
                    this.RaisePropertyChanged("HashedPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
    [System.SerializableAttribute()]
    public partial class ServiceFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiskDto", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.DataTransferObjects")]
    [System.SerializableAttribute()]
    public partial class DiskDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LastServerVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LocalVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NewestBlockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LastServerVersion {
            get {
                return this.LastServerVersionField;
            }
            set {
                if ((this.LastServerVersionField.Equals(value) != true)) {
                    this.LastServerVersionField = value;
                    this.RaisePropertyChanged("LastServerVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LocalVersion {
            get {
                return this.LocalVersionField;
            }
            set {
                if ((this.LocalVersionField.Equals(value) != true)) {
                    this.LocalVersionField = value;
                    this.RaisePropertyChanged("LocalVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NewestBlock {
            get {
                return this.NewestBlockField;
            }
            set {
                if ((this.NewestBlockField.Equals(value) != true)) {
                    this.NewestBlockField = value;
                    this.RaisePropertyChanged("NewestBlock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DiskOptionsDto", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.DataTransferObjects")]
    [System.SerializableAttribute()]
    public partial class DiskOptionsDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BlockSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DiskIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MasterBlockSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] SerializedFileSystemOptionsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BlockSize {
            get {
                return this.BlockSizeField;
            }
            set {
                if ((this.BlockSizeField.Equals(value) != true)) {
                    this.BlockSizeField = value;
                    this.RaisePropertyChanged("BlockSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DiskId {
            get {
                return this.DiskIdField;
            }
            set {
                if ((this.DiskIdField.Equals(value) != true)) {
                    this.DiskIdField = value;
                    this.RaisePropertyChanged("DiskId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MasterBlockSize {
            get {
                return this.MasterBlockSizeField;
            }
            set {
                if ((this.MasterBlockSizeField.Equals(value) != true)) {
                    this.MasterBlockSizeField = value;
                    this.RaisePropertyChanged("MasterBlockSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] SerializedFileSystemOptions {
            get {
                return this.SerializedFileSystemOptionsField;
            }
            set {
                if ((object.ReferenceEquals(this.SerializedFileSystemOptionsField, value) != true)) {
                    this.SerializedFileSystemOptionsField = value;
                    this.RaisePropertyChanged("SerializedFileSystemOptions");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SynchronizationState", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.DataTransferObjects")]
    public enum SynchronizationState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RemoteChanges = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LocalChanges = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Conflicted = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UpToDate = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DiskServiceReference.IDiskService")]
    public interface IDiskService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Register", ReplyAction="http://tempuri.org/IDiskService/RegisterResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/RegisterServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        Startup.DiskServiceReference.UserDto Register(string login, string hashedPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Register", ReplyAction="http://tempuri.org/IDiskService/RegisterResponse")]
        System.Threading.Tasks.Task<Startup.DiskServiceReference.UserDto> RegisterAsync(string login, string hashedPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Login", ReplyAction="http://tempuri.org/IDiskService/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/LoginServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        Startup.DiskServiceReference.UserDto Login(string loginName, string hashedPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Login", ReplyAction="http://tempuri.org/IDiskService/LoginResponse")]
        System.Threading.Tasks.Task<Startup.DiskServiceReference.UserDto> LoginAsync(string loginName, string hashedPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Disks", ReplyAction="http://tempuri.org/IDiskService/DisksResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/DisksServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        Startup.DiskServiceReference.DiskDto[] Disks(Startup.DiskServiceReference.UserDto userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Disks", ReplyAction="http://tempuri.org/IDiskService/DisksResponse")]
        System.Threading.Tasks.Task<Startup.DiskServiceReference.DiskDto[]> DisksAsync(Startup.DiskServiceReference.UserDto userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/CreateDisk", ReplyAction="http://tempuri.org/IDiskService/CreateDiskResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/CreateDiskServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        Startup.DiskServiceReference.DiskDto CreateDisk(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/CreateDisk", ReplyAction="http://tempuri.org/IDiskService/CreateDiskResponse")]
        System.Threading.Tasks.Task<Startup.DiskServiceReference.DiskDto> CreateDiskAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/DeleteDisk", ReplyAction="http://tempuri.org/IDiskService/DeleteDiskResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/DeleteDiskServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        bool DeleteDisk(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/DeleteDisk", ReplyAction="http://tempuri.org/IDiskService/DeleteDiskResponse")]
        System.Threading.Tasks.Task<bool> DeleteDiskAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/FetchSynchronizationState", ReplyAction="http://tempuri.org/IDiskService/FetchSynchronizationStateResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/FetchSynchronizationStateServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        Startup.DiskServiceReference.SynchronizationState FetchSynchronizationState(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/FetchSynchronizationState", ReplyAction="http://tempuri.org/IDiskService/FetchSynchronizationStateResponse")]
        System.Threading.Tasks.Task<Startup.DiskServiceReference.SynchronizationState> FetchSynchronizationStateAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/GetDiskOptions", ReplyAction="http://tempuri.org/IDiskService/GetDiskOptionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/GetDiskOptionsServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        Startup.DiskServiceReference.DiskOptionsDto GetDiskOptions(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/GetDiskOptions", ReplyAction="http://tempuri.org/IDiskService/GetDiskOptionsResponse")]
        System.Threading.Tasks.Task<Startup.DiskServiceReference.DiskOptionsDto> GetDiskOptionsAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/SetDiskOptions", ReplyAction="http://tempuri.org/IDiskService/SetDiskOptionsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/SetDiskOptionsServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        void SetDiskOptions(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/SetDiskOptions", ReplyAction="http://tempuri.org/IDiskService/SetDiskOptionsResponse")]
        System.Threading.Tasks.Task SetDiskOptionsAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/WriteBlock", ReplyAction="http://tempuri.org/IDiskService/WriteBlockResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/WriteBlockServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        void WriteBlock(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr, byte[] content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/WriteBlock", ReplyAction="http://tempuri.org/IDiskService/WriteBlockResponse")]
        System.Threading.Tasks.Task WriteBlockAsync(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr, byte[] content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/ReadBlock", ReplyAction="http://tempuri.org/IDiskService/ReadBlockResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/ReadBlockServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        byte[] ReadBlock(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/ReadBlock", ReplyAction="http://tempuri.org/IDiskService/ReadBlockResponse")]
        System.Threading.Tasks.Task<byte[]> ReadBlockAsync(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/UpdateDisk", ReplyAction="http://tempuri.org/IDiskService/UpdateDiskResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Startup.DiskServiceReference.ServiceFault), Action="http://tempuri.org/IDiskService/UpdateDiskServiceFaultFault", Name="ServiceFault", Namespace="http://schemas.datacontract.org/2004/07/VFSWCFContracts.FaultContracts")]
        void UpdateDisk(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/UpdateDisk", ReplyAction="http://tempuri.org/IDiskService/UpdateDiskResponse")]
        System.Threading.Tasks.Task UpdateDiskAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDiskServiceChannel : Startup.DiskServiceReference.IDiskService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DiskServiceClient : System.ServiceModel.ClientBase<Startup.DiskServiceReference.IDiskService>, Startup.DiskServiceReference.IDiskService {
        
        public DiskServiceClient() {
        }
        
        public DiskServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DiskServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DiskServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DiskServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Startup.DiskServiceReference.UserDto Register(string login, string hashedPassword) {
            return base.Channel.Register(login, hashedPassword);
        }
        
        public System.Threading.Tasks.Task<Startup.DiskServiceReference.UserDto> RegisterAsync(string login, string hashedPassword) {
            return base.Channel.RegisterAsync(login, hashedPassword);
        }
        
        public Startup.DiskServiceReference.UserDto Login(string loginName, string hashedPassword) {
            return base.Channel.Login(loginName, hashedPassword);
        }
        
        public System.Threading.Tasks.Task<Startup.DiskServiceReference.UserDto> LoginAsync(string loginName, string hashedPassword) {
            return base.Channel.LoginAsync(loginName, hashedPassword);
        }
        
        public Startup.DiskServiceReference.DiskDto[] Disks(Startup.DiskServiceReference.UserDto userDto) {
            return base.Channel.Disks(userDto);
        }
        
        public System.Threading.Tasks.Task<Startup.DiskServiceReference.DiskDto[]> DisksAsync(Startup.DiskServiceReference.UserDto userDto) {
            return base.Channel.DisksAsync(userDto);
        }
        
        public Startup.DiskServiceReference.DiskDto CreateDisk(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto) {
            return base.Channel.CreateDisk(userDto, optionsDto);
        }
        
        public System.Threading.Tasks.Task<Startup.DiskServiceReference.DiskDto> CreateDiskAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto) {
            return base.Channel.CreateDiskAsync(userDto, optionsDto);
        }
        
        public bool DeleteDisk(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            return base.Channel.DeleteDisk(userDto, diskDto);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteDiskAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            return base.Channel.DeleteDiskAsync(userDto, diskDto);
        }
        
        public Startup.DiskServiceReference.SynchronizationState FetchSynchronizationState(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            return base.Channel.FetchSynchronizationState(userDto, diskDto);
        }
        
        public System.Threading.Tasks.Task<Startup.DiskServiceReference.SynchronizationState> FetchSynchronizationStateAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            return base.Channel.FetchSynchronizationStateAsync(userDto, diskDto);
        }
        
        public Startup.DiskServiceReference.DiskOptionsDto GetDiskOptions(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            return base.Channel.GetDiskOptions(userDto, diskDto);
        }
        
        public System.Threading.Tasks.Task<Startup.DiskServiceReference.DiskOptionsDto> GetDiskOptionsAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            return base.Channel.GetDiskOptionsAsync(userDto, diskDto);
        }
        
        public void SetDiskOptions(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto) {
            base.Channel.SetDiskOptions(userDto, diskDto, optionsDto);
        }
        
        public System.Threading.Tasks.Task SetDiskOptionsAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto, Startup.DiskServiceReference.DiskOptionsDto optionsDto) {
            return base.Channel.SetDiskOptionsAsync(userDto, diskDto, optionsDto);
        }
        
        public void WriteBlock(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr, byte[] content) {
            base.Channel.WriteBlock(userDto, diskId, blockNr, content);
        }
        
        public System.Threading.Tasks.Task WriteBlockAsync(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr, byte[] content) {
            return base.Channel.WriteBlockAsync(userDto, diskId, blockNr, content);
        }
        
        public byte[] ReadBlock(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr) {
            return base.Channel.ReadBlock(userDto, diskId, blockNr);
        }
        
        public System.Threading.Tasks.Task<byte[]> ReadBlockAsync(Startup.DiskServiceReference.UserDto userDto, int diskId, long blockNr) {
            return base.Channel.ReadBlockAsync(userDto, diskId, blockNr);
        }
        
        public void UpdateDisk(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            base.Channel.UpdateDisk(userDto, diskDto);
        }
        
        public System.Threading.Tasks.Task UpdateDiskAsync(Startup.DiskServiceReference.UserDto userDto, Startup.DiskServiceReference.DiskDto diskDto) {
            return base.Channel.UpdateDiskAsync(userDto, diskDto);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VFSPrototype.DiskServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DiskServiceReference.IDiskService")]
    public interface IDiskService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Ish", ReplyAction="http://tempuri.org/IDiskService/IshResponse")]
        string Ish(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDiskService/Ish", ReplyAction="http://tempuri.org/IDiskService/IshResponse")]
        System.Threading.Tasks.Task<string> IshAsync(string input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDiskServiceChannel : VFSPrototype.DiskServiceReference.IDiskService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DiskServiceClient : System.ServiceModel.ClientBase<VFSPrototype.DiskServiceReference.IDiskService>, VFSPrototype.DiskServiceReference.IDiskService {
        
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
        
        public string Ish(string input) {
            return base.Channel.Ish(input);
        }
        
        public System.Threading.Tasks.Task<string> IshAsync(string input) {
            return base.Channel.IshAsync(input);
        }
    }
}

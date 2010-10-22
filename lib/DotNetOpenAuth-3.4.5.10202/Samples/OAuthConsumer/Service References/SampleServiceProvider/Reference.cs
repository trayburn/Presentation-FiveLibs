﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAuthConsumer.SampleServiceProvider {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SampleServiceProvider.IDataApi")]
    public interface IDataApi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataApi/GetAge", ReplyAction="http://tempuri.org/IDataApi/GetAgeResponse")]
        System.Nullable<int> GetAge();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataApi/GetName", ReplyAction="http://tempuri.org/IDataApi/GetNameResponse")]
        string GetName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataApi/GetFavoriteSites", ReplyAction="http://tempuri.org/IDataApi/GetFavoriteSitesResponse")]
        string[] GetFavoriteSites();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataApiChannel : OAuthConsumer.SampleServiceProvider.IDataApi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataApiClient : System.ServiceModel.ClientBase<OAuthConsumer.SampleServiceProvider.IDataApi>, OAuthConsumer.SampleServiceProvider.IDataApi {
        
        public DataApiClient() {
        }
        
        public DataApiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataApiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataApiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataApiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Nullable<int> GetAge() {
            return base.Channel.GetAge();
        }
        
        public string GetName() {
            return base.Channel.GetName();
        }
        
        public string[] GetFavoriteSites() {
            return base.Channel.GetFavoriteSites();
        }
    }
}

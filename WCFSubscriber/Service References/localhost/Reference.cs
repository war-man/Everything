﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFSubscriber.localhost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="localhost.IPublisher", CallbackContract=typeof(WCFSubscriber.localhost.IPublisherCallback))]
    public interface IPublisher {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublisher/Subscriber", ReplyAction="http://tempuri.org/IPublisher/SubscriberResponse")]
        void Subscriber(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublisher/UnSubscriber", ReplyAction="http://tempuri.org/IPublisher/UnSubscriberResponse")]
        void UnSubscriber(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPublisher/Trigger", ReplyAction="http://tempuri.org/IPublisher/TriggerResponse")]
        void Trigger();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublisherCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPublisher/Notify")]
        void Notify();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPublisherChannel : WCFSubscriber.localhost.IPublisher, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PublisherClient : System.ServiceModel.DuplexClientBase<WCFSubscriber.localhost.IPublisher>, WCFSubscriber.localhost.IPublisher {
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PublisherClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscriber(System.Guid id) {
            base.Channel.Subscriber(id);
        }
        
        public void UnSubscriber(System.Guid id) {
            base.Channel.UnSubscriber(id);
        }
        
        public void Trigger() {
            base.Channel.Trigger();
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Services.TrackingNumberServices.RefAPI.TrackNumber {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResutlInfoOfstring", Namespace="http://schemas.datacontract.org/2004/07/LMS.WCF.TrackNumber.Dto")]
    [System.SerializableAttribute()]
    public partial class ResutlInfoOfstring : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
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
        public string[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefAPI.TrackNumber.ITrackNumberAssign")]
    public interface ITrackNumberAssign {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrackNumberAssign/TrackNumberAssignStandard", ReplyAction="http://tempuri.org/ITrackNumberAssign/TrackNumberAssignStandardResponse")]
        LMS.Services.TrackingNumberServices.RefAPI.TrackNumber.ResutlInfoOfstring TrackNumberAssignStandard(int shippingMethodId, int count, string countryCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrackNumberAssignChannel : LMS.Services.TrackingNumberServices.RefAPI.TrackNumber.ITrackNumberAssign, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrackNumberAssignClient : System.ServiceModel.ClientBase<LMS.Services.TrackingNumberServices.RefAPI.TrackNumber.ITrackNumberAssign>, LMS.Services.TrackingNumberServices.RefAPI.TrackNumber.ITrackNumberAssign {
        
        public TrackNumberAssignClient() {
        }
        
        public TrackNumberAssignClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TrackNumberAssignClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrackNumberAssignClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrackNumberAssignClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LMS.Services.TrackingNumberServices.RefAPI.TrackNumber.ResutlInfoOfstring TrackNumberAssignStandard(int shippingMethodId, int count, string countryCode) {
            return base.Channel.TrackNumberAssignStandard(shippingMethodId, count, countryCode);
        }
    }
}
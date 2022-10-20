﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business.PaymentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreatePaymentModel", Namespace="http://schemas.datacontract.org/2004/07/PaymentService")]
    [System.SerializableAttribute()]
    public partial class CreatePaymentModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreditCardNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CvvField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExpireDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public string CreditCardNo {
            get {
                return this.CreditCardNoField;
            }
            set {
                if ((object.ReferenceEquals(this.CreditCardNoField, value) != true)) {
                    this.CreditCardNoField = value;
                    this.RaisePropertyChanged("CreditCardNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cvv {
            get {
                return this.CvvField;
            }
            set {
                if ((this.CvvField.Equals(value) != true)) {
                    this.CvvField = value;
                    this.RaisePropertyChanged("Cvv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExpireDate {
            get {
                return this.ExpireDateField;
            }
            set {
                if ((object.ReferenceEquals(this.ExpireDateField, value) != true)) {
                    this.ExpireDateField = value;
                    this.RaisePropertyChanged("ExpireDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaymentService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pay", ReplyAction="http://tempuri.org/IService1/PayResponse")]
        bool Pay(Business.PaymentService.CreatePaymentModel createPaymentModel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pay", ReplyAction="http://tempuri.org/IService1/PayResponse")]
        System.Threading.Tasks.Task<bool> PayAsync(Business.PaymentService.CreatePaymentModel createPaymentModel);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Business.PaymentService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Business.PaymentService.IService1>, Business.PaymentService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Pay(Business.PaymentService.CreatePaymentModel createPaymentModel) {
            return base.Channel.Pay(createPaymentModel);
        }
        
        public System.Threading.Tasks.Task<bool> PayAsync(Business.PaymentService.CreatePaymentModel createPaymentModel) {
            return base.Channel.PayAsync(createPaymentModel);
        }
    }
}
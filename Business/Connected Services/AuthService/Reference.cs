﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business.AuthService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthService.AuthServiceSoap")]
    public interface AuthServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        // CODEGEN: Generating message contract since message SayHiRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SayHi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Business.AuthService.SayHiResponse SayHi(Business.AuthService.SayHiRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SayHi", ReplyAction="*")]
        System.Threading.Tasks.Task<Business.AuthService.SayHiResponse> SayHiAsync(Business.AuthService.SayHiRequest request);
        
        // CODEGEN: Generating message contract since message LoginRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Business.AuthService.LoginResponse Login(Business.AuthService.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<Business.AuthService.LoginResponse> LoginAsync(Business.AuthService.LoginRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthUser : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string usernameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SayHi", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SayHiRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Business.AuthService.AuthUser AuthUser;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        public SayHiRequest() {
        }
        
        public SayHiRequest(Business.AuthService.AuthUser AuthUser, string name) {
            this.AuthUser = AuthUser;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SayHiResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SayHiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string SayHiResult;
        
        public SayHiResponse() {
        }
        
        public SayHiResponse(string SayHiResult) {
            this.SayHiResult = SayHiResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Login", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public Business.AuthService.AuthUser AuthUser;
        
        public LoginRequest() {
        }
        
        public LoginRequest(Business.AuthService.AuthUser AuthUser) {
            this.AuthUser = AuthUser;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="LoginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool LoginResult;
        
        public LoginResponse() {
        }
        
        public LoginResponse(bool LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthServiceSoapChannel : Business.AuthService.AuthServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceSoapClient : System.ServiceModel.ClientBase<Business.AuthService.AuthServiceSoap>, Business.AuthService.AuthServiceSoap {
        
        public AuthServiceSoapClient() {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Business.AuthService.SayHiResponse Business.AuthService.AuthServiceSoap.SayHi(Business.AuthService.SayHiRequest request) {
            return base.Channel.SayHi(request);
        }
        
        public string SayHi(Business.AuthService.AuthUser AuthUser, string name) {
            Business.AuthService.SayHiRequest inValue = new Business.AuthService.SayHiRequest();
            inValue.AuthUser = AuthUser;
            inValue.name = name;
            Business.AuthService.SayHiResponse retVal = ((Business.AuthService.AuthServiceSoap)(this)).SayHi(inValue);
            return retVal.SayHiResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Business.AuthService.SayHiResponse> Business.AuthService.AuthServiceSoap.SayHiAsync(Business.AuthService.SayHiRequest request) {
            return base.Channel.SayHiAsync(request);
        }
        
        public System.Threading.Tasks.Task<Business.AuthService.SayHiResponse> SayHiAsync(Business.AuthService.AuthUser AuthUser, string name) {
            Business.AuthService.SayHiRequest inValue = new Business.AuthService.SayHiRequest();
            inValue.AuthUser = AuthUser;
            inValue.name = name;
            return ((Business.AuthService.AuthServiceSoap)(this)).SayHiAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Business.AuthService.LoginResponse Business.AuthService.AuthServiceSoap.Login(Business.AuthService.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public bool Login(Business.AuthService.AuthUser AuthUser) {
            Business.AuthService.LoginRequest inValue = new Business.AuthService.LoginRequest();
            inValue.AuthUser = AuthUser;
            Business.AuthService.LoginResponse retVal = ((Business.AuthService.AuthServiceSoap)(this)).Login(inValue);
            return retVal.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Business.AuthService.LoginResponse> Business.AuthService.AuthServiceSoap.LoginAsync(Business.AuthService.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Business.AuthService.LoginResponse> LoginAsync(Business.AuthService.AuthUser AuthUser) {
            Business.AuthService.LoginRequest inValue = new Business.AuthService.LoginRequest();
            inValue.AuthUser = AuthUser;
            return ((Business.AuthService.AuthServiceSoap)(this)).LoginAsync(inValue);
        }
    }
}

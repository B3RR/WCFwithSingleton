﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFwithSingleton.Cmd.WCFwithSingletonWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Request", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest))]
    public partial class Request : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private WCFwithSingleton.Cmd.WCFwithSingletonWS.AuthenticationRequest AuthenticationRequestField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public WCFwithSingleton.Cmd.WCFwithSingletonWS.AuthenticationRequest AuthenticationRequest {
            get {
                return this.AuthenticationRequestField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthenticationRequestField, value) != true)) {
                    this.AuthenticationRequestField = value;
                    this.RaisePropertyChanged("AuthenticationRequest");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationRequest", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    [System.SerializableAttribute()]
    public partial class AuthenticationRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string UserIdField;
        
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIdField, value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TestRequest", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    [System.SerializableAttribute()]
    public partial class TestRequest : WCFwithSingleton.Cmd.WCFwithSingletonWS.Request {
        
        private string MessageTextField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string MessageText {
            get {
                return this.MessageTextField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageTextField, value) != true)) {
                    this.MessageTextField = value;
                    this.RaisePropertyChanged("MessageText");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse))]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private WCFwithSingleton.Cmd.WCFwithSingletonWS.ResponseInfo ResponseInfoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public WCFwithSingleton.Cmd.WCFwithSingletonWS.ResponseInfo ResponseInfo {
            get {
                return this.ResponseInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ResponseInfoField, value) != true)) {
                    this.ResponseInfoField = value;
                    this.RaisePropertyChanged("ResponseInfo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseInfo", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    [System.SerializableAttribute()]
    public partial class ResponseInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WCFwithSingleton.Cmd.WCFwithSingletonWS.AuthenticationResponse AuthenticationResponseField;
        
        private WCFwithSingleton.Cmd.WCFwithSingletonWS.ResponseType ResponseTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public WCFwithSingleton.Cmd.WCFwithSingletonWS.AuthenticationResponse AuthenticationResponse {
            get {
                return this.AuthenticationResponseField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthenticationResponseField, value) != true)) {
                    this.AuthenticationResponseField = value;
                    this.RaisePropertyChanged("AuthenticationResponse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public WCFwithSingleton.Cmd.WCFwithSingletonWS.ResponseType ResponseType {
            get {
                return this.ResponseTypeField;
            }
            set {
                if ((this.ResponseTypeField.Equals(value) != true)) {
                    this.ResponseTypeField = value;
                    this.RaisePropertyChanged("ResponseType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ErrorText {
            get {
                return this.ErrorTextField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorTextField, value) != true)) {
                    this.ErrorTextField = value;
                    this.RaisePropertyChanged("ErrorText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TestResponse", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    [System.SerializableAttribute()]
    public partial class TestResponse : WCFwithSingleton.Cmd.WCFwithSingletonWS.Response {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageTextField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MessageText {
            get {
                return this.MessageTextField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageTextField, value) != true)) {
                    this.MessageTextField = value;
                    this.RaisePropertyChanged("MessageText");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationResponse", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    [System.SerializableAttribute()]
    public partial class AuthenticationResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIdField, value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseType", Namespace="http://WCFwithSingleton.ws.gonis.ru")]
    public enum ResponseType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fail = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WCFwithSingleton.ws.gonis.ru", ConfigurationName="WCFwithSingletonWS.IWCFwithSingletonWS")]
    public interface IWCFwithSingletonWS {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTest", ReplyAction="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTestResponse")]
        WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse GetTest(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTest", ReplyAction="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTestResponse")]
        System.Threading.Tasks.Task<WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse> GetTestAsync(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTestWithSingleton", ReplyAction="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTestWithSingletonRespo" +
            "nse")]
        WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse GetTestWithSingleton(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTestWithSingleton", ReplyAction="http://WCFwithSingleton.ws.gonis.ru/IWCFwithSingletonWS/GetTestWithSingletonRespo" +
            "nse")]
        System.Threading.Tasks.Task<WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse> GetTestWithSingletonAsync(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFwithSingletonWSChannel : WCFwithSingleton.Cmd.WCFwithSingletonWS.IWCFwithSingletonWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFwithSingletonWSClient : System.ServiceModel.ClientBase<WCFwithSingleton.Cmd.WCFwithSingletonWS.IWCFwithSingletonWS>, WCFwithSingleton.Cmd.WCFwithSingletonWS.IWCFwithSingletonWS {
        
        public WCFwithSingletonWSClient() {
        }
        
        public WCFwithSingletonWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFwithSingletonWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFwithSingletonWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFwithSingletonWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse GetTest(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest) {
            return base.Channel.GetTest(TestRequest);
        }
        
        public System.Threading.Tasks.Task<WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse> GetTestAsync(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest) {
            return base.Channel.GetTestAsync(TestRequest);
        }
        
        public WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse GetTestWithSingleton(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest) {
            return base.Channel.GetTestWithSingleton(TestRequest);
        }
        
        public System.Threading.Tasks.Task<WCFwithSingleton.Cmd.WCFwithSingletonWS.TestResponse> GetTestWithSingletonAsync(WCFwithSingleton.Cmd.WCFwithSingletonWS.TestRequest TestRequest) {
            return base.Channel.GetTestWithSingletonAsync(TestRequest);
        }
    }
}

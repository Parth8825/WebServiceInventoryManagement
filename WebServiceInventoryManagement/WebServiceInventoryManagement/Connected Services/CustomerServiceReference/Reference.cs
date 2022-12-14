//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceInventoryManagement.CustomerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerBO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CustomerBO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CustomerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        private double GradeField;
        
        private int SalesIdField;
        
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
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string CustomerName {
            get {
                return this.CustomerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerNameField, value) != true)) {
                    this.CustomerNameField = value;
                    this.RaisePropertyChanged("CustomerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public double Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((this.GradeField.Equals(value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int SalesId {
            get {
                return this.SalesIdField;
            }
            set {
                if ((this.SalesIdField.Equals(value) != true)) {
                    this.SalesIdField = value;
                    this.RaisePropertyChanged("SalesId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerServiceReference.CustomerServiceSoap")]
    public interface CustomerServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetCustomerResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCustomer", ReplyAction="*")]
        WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponse GetCustomer(WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCustomer", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponse> GetCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest request);
        
        // CODEGEN: Generating message contract since element name newCustomer from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNewCustomer", ReplyAction="*")]
        WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponse InsertNewCustomer(WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNewCustomer", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponse> InsertNewCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest request);
        
        // CODEGEN: Generating message contract since element name customer from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCustomer", ReplyAction="*")]
        WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponse UpdateCustomer(WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCustomer", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponse> UpdateCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest request);
        
        // CODEGEN: Generating message contract since element name customer from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteCustomer", ReplyAction="*")]
        WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponse DeleteCustomer(WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteCustomer", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponse> DeleteCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCustomer", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequestBody Body;
        
        public GetCustomerRequest() {
        }
        
        public GetCustomerRequest(WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCustomerRequestBody {
        
        public GetCustomerRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCustomerResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponseBody Body;
        
        public GetCustomerResponse() {
        }
        
        public GetCustomerResponse(WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.CustomerBO[] GetCustomerResult;
        
        public GetCustomerResponseBody() {
        }
        
        public GetCustomerResponseBody(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO[] GetCustomerResult) {
            this.GetCustomerResult = GetCustomerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNewCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNewCustomer", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequestBody Body;
        
        public InsertNewCustomerRequest() {
        }
        
        public InsertNewCustomerRequest(WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNewCustomerRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.CustomerBO newCustomer;
        
        public InsertNewCustomerRequestBody() {
        }
        
        public InsertNewCustomerRequestBody(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO newCustomer) {
            this.newCustomer = newCustomer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNewCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNewCustomerResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponseBody Body;
        
        public InsertNewCustomerResponse() {
        }
        
        public InsertNewCustomerResponse(WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNewCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertNewCustomerResult;
        
        public InsertNewCustomerResponseBody() {
        }
        
        public InsertNewCustomerResponseBody(int InsertNewCustomerResult) {
            this.InsertNewCustomerResult = InsertNewCustomerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateCustomer", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequestBody Body;
        
        public UpdateCustomerRequest() {
        }
        
        public UpdateCustomerRequest(WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateCustomerRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer;
        
        public UpdateCustomerRequestBody() {
        }
        
        public UpdateCustomerRequestBody(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer) {
            this.customer = customer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateCustomerResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponseBody Body;
        
        public UpdateCustomerResponse() {
        }
        
        public UpdateCustomerResponse(WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdateCustomerResult;
        
        public UpdateCustomerResponseBody() {
        }
        
        public UpdateCustomerResponseBody(int UpdateCustomerResult) {
            this.UpdateCustomerResult = UpdateCustomerResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteCustomerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteCustomer", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequestBody Body;
        
        public DeleteCustomerRequest() {
        }
        
        public DeleteCustomerRequest(WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteCustomerRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer;
        
        public DeleteCustomerRequestBody() {
        }
        
        public DeleteCustomerRequestBody(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer) {
            this.customer = customer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteCustomerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteCustomerResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponseBody Body;
        
        public DeleteCustomerResponse() {
        }
        
        public DeleteCustomerResponse(WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteCustomerResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DeleteCustomerResult;
        
        public DeleteCustomerResponseBody() {
        }
        
        public DeleteCustomerResponseBody(int DeleteCustomerResult) {
            this.DeleteCustomerResult = DeleteCustomerResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustomerServiceSoapChannel : WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceSoapClient : System.ServiceModel.ClientBase<WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap>, WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap {
        
        public CustomerServiceSoapClient() {
        }
        
        public CustomerServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponse WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.GetCustomer(WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest request) {
            return base.Channel.GetCustomer(request);
        }
        
        public WebServiceInventoryManagement.CustomerServiceReference.CustomerBO[] GetCustomer() {
            WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequestBody();
            WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponse retVal = ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).GetCustomer(inValue);
            return retVal.Body.GetCustomerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponse> WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.GetCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest request) {
            return base.Channel.GetCustomerAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.GetCustomerResponse> GetCustomerAsync() {
            WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.GetCustomerRequestBody();
            return ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).GetCustomerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponse WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.InsertNewCustomer(WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest request) {
            return base.Channel.InsertNewCustomer(request);
        }
        
        public int InsertNewCustomer(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO newCustomer) {
            WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequestBody();
            inValue.Body.newCustomer = newCustomer;
            WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponse retVal = ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).InsertNewCustomer(inValue);
            return retVal.Body.InsertNewCustomerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponse> WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.InsertNewCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest request) {
            return base.Channel.InsertNewCustomerAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerResponse> InsertNewCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO newCustomer) {
            WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.InsertNewCustomerRequestBody();
            inValue.Body.newCustomer = newCustomer;
            return ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).InsertNewCustomerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponse WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.UpdateCustomer(WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest request) {
            return base.Channel.UpdateCustomer(request);
        }
        
        public int UpdateCustomer(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer) {
            WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequestBody();
            inValue.Body.customer = customer;
            WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponse retVal = ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).UpdateCustomer(inValue);
            return retVal.Body.UpdateCustomerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponse> WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.UpdateCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest request) {
            return base.Channel.UpdateCustomerAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerResponse> UpdateCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer) {
            WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.UpdateCustomerRequestBody();
            inValue.Body.customer = customer;
            return ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).UpdateCustomerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponse WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.DeleteCustomer(WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest request) {
            return base.Channel.DeleteCustomer(request);
        }
        
        public int DeleteCustomer(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer) {
            WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequestBody();
            inValue.Body.customer = customer;
            WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponse retVal = ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).DeleteCustomer(inValue);
            return retVal.Body.DeleteCustomerResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponse> WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap.DeleteCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest request) {
            return base.Channel.DeleteCustomerAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerResponse> DeleteCustomerAsync(WebServiceInventoryManagement.CustomerServiceReference.CustomerBO customer) {
            WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest inValue = new WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequest();
            inValue.Body = new WebServiceInventoryManagement.CustomerServiceReference.DeleteCustomerRequestBody();
            inValue.Body.customer = customer;
            return ((WebServiceInventoryManagement.CustomerServiceReference.CustomerServiceSoap)(this)).DeleteCustomerAsync(inValue);
        }
    }
}

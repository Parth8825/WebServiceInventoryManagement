//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceInventoryManagement.SalesmanServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SalesmanBO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class SalesmanBO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int SalesmanIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalesmanNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        private double CommisionField;
        
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
        public int SalesmanId {
            get {
                return this.SalesmanIdField;
            }
            set {
                if ((this.SalesmanIdField.Equals(value) != true)) {
                    this.SalesmanIdField = value;
                    this.RaisePropertyChanged("SalesmanId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string SalesmanName {
            get {
                return this.SalesmanNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SalesmanNameField, value) != true)) {
                    this.SalesmanNameField = value;
                    this.RaisePropertyChanged("SalesmanName");
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
        public double Commision {
            get {
                return this.CommisionField;
            }
            set {
                if ((this.CommisionField.Equals(value) != true)) {
                    this.CommisionField = value;
                    this.RaisePropertyChanged("Commision");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalesmanServiceReference.SalesmanServiceSoap")]
    public interface SalesmanServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetSalesmanResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSalesman", ReplyAction="*")]
        WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponse GetSalesman(WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSalesman", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponse> GetSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest request);
        
        // CODEGEN: Generating message contract since element name newSalesman from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNewSalesman", ReplyAction="*")]
        WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponse InsertNewSalesman(WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNewSalesman", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponse> InsertNewSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest request);
        
        // CODEGEN: Generating message contract since element name salesman from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateSalesman", ReplyAction="*")]
        WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponse UpdateSalesman(WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateSalesman", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponse> UpdateSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest request);
        
        // CODEGEN: Generating message contract since element name salesman from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteSalesman", ReplyAction="*")]
        WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponse DeleteSalesman(WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteSalesman", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponse> DeleteSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSalesmanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSalesman", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequestBody Body;
        
        public GetSalesmanRequest() {
        }
        
        public GetSalesmanRequest(WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetSalesmanRequestBody {
        
        public GetSalesmanRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSalesmanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSalesmanResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponseBody Body;
        
        public GetSalesmanResponse() {
        }
        
        public GetSalesmanResponse(WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetSalesmanResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO[] GetSalesmanResult;
        
        public GetSalesmanResponseBody() {
        }
        
        public GetSalesmanResponseBody(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO[] GetSalesmanResult) {
            this.GetSalesmanResult = GetSalesmanResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNewSalesmanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNewSalesman", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequestBody Body;
        
        public InsertNewSalesmanRequest() {
        }
        
        public InsertNewSalesmanRequest(WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNewSalesmanRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO newSalesman;
        
        public InsertNewSalesmanRequestBody() {
        }
        
        public InsertNewSalesmanRequestBody(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO newSalesman) {
            this.newSalesman = newSalesman;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNewSalesmanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNewSalesmanResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponseBody Body;
        
        public InsertNewSalesmanResponse() {
        }
        
        public InsertNewSalesmanResponse(WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNewSalesmanResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertNewSalesmanResult;
        
        public InsertNewSalesmanResponseBody() {
        }
        
        public InsertNewSalesmanResponseBody(int InsertNewSalesmanResult) {
            this.InsertNewSalesmanResult = InsertNewSalesmanResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateSalesmanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateSalesman", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequestBody Body;
        
        public UpdateSalesmanRequest() {
        }
        
        public UpdateSalesmanRequest(WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateSalesmanRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman;
        
        public UpdateSalesmanRequestBody() {
        }
        
        public UpdateSalesmanRequestBody(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman) {
            this.salesman = salesman;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateSalesmanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateSalesmanResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponseBody Body;
        
        public UpdateSalesmanResponse() {
        }
        
        public UpdateSalesmanResponse(WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateSalesmanResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdateSalesmanResult;
        
        public UpdateSalesmanResponseBody() {
        }
        
        public UpdateSalesmanResponseBody(int UpdateSalesmanResult) {
            this.UpdateSalesmanResult = UpdateSalesmanResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSalesmanRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSalesman", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequestBody Body;
        
        public DeleteSalesmanRequest() {
        }
        
        public DeleteSalesmanRequest(WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteSalesmanRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman;
        
        public DeleteSalesmanRequestBody() {
        }
        
        public DeleteSalesmanRequestBody(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman) {
            this.salesman = salesman;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteSalesmanResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteSalesmanResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponseBody Body;
        
        public DeleteSalesmanResponse() {
        }
        
        public DeleteSalesmanResponse(WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteSalesmanResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DeleteSalesmanResult;
        
        public DeleteSalesmanResponseBody() {
        }
        
        public DeleteSalesmanResponseBody(int DeleteSalesmanResult) {
            this.DeleteSalesmanResult = DeleteSalesmanResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SalesmanServiceSoapChannel : WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalesmanServiceSoapClient : System.ServiceModel.ClientBase<WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap>, WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap {
        
        public SalesmanServiceSoapClient() {
        }
        
        public SalesmanServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalesmanServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesmanServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesmanServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponse WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.GetSalesman(WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest request) {
            return base.Channel.GetSalesman(request);
        }
        
        public WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO[] GetSalesman() {
            WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequestBody();
            WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponse retVal = ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).GetSalesman(inValue);
            return retVal.Body.GetSalesmanResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponse> WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.GetSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest request) {
            return base.Channel.GetSalesmanAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanResponse> GetSalesmanAsync() {
            WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.GetSalesmanRequestBody();
            return ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).GetSalesmanAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponse WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.InsertNewSalesman(WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest request) {
            return base.Channel.InsertNewSalesman(request);
        }
        
        public int InsertNewSalesman(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO newSalesman) {
            WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequestBody();
            inValue.Body.newSalesman = newSalesman;
            WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponse retVal = ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).InsertNewSalesman(inValue);
            return retVal.Body.InsertNewSalesmanResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponse> WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.InsertNewSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest request) {
            return base.Channel.InsertNewSalesmanAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanResponse> InsertNewSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO newSalesman) {
            WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.InsertNewSalesmanRequestBody();
            inValue.Body.newSalesman = newSalesman;
            return ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).InsertNewSalesmanAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponse WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.UpdateSalesman(WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest request) {
            return base.Channel.UpdateSalesman(request);
        }
        
        public int UpdateSalesman(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman) {
            WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequestBody();
            inValue.Body.salesman = salesman;
            WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponse retVal = ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).UpdateSalesman(inValue);
            return retVal.Body.UpdateSalesmanResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponse> WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.UpdateSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest request) {
            return base.Channel.UpdateSalesmanAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanResponse> UpdateSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman) {
            WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.UpdateSalesmanRequestBody();
            inValue.Body.salesman = salesman;
            return ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).UpdateSalesmanAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponse WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.DeleteSalesman(WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest request) {
            return base.Channel.DeleteSalesman(request);
        }
        
        public int DeleteSalesman(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman) {
            WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequestBody();
            inValue.Body.salesman = salesman;
            WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponse retVal = ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).DeleteSalesman(inValue);
            return retVal.Body.DeleteSalesmanResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponse> WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap.DeleteSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest request) {
            return base.Channel.DeleteSalesmanAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanResponse> DeleteSalesmanAsync(WebServiceInventoryManagement.SalesmanServiceReference.SalesmanBO salesman) {
            WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest inValue = new WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequest();
            inValue.Body = new WebServiceInventoryManagement.SalesmanServiceReference.DeleteSalesmanRequestBody();
            inValue.Body.salesman = salesman;
            return ((WebServiceInventoryManagement.SalesmanServiceReference.SalesmanServiceSoap)(this)).DeleteSalesmanAsync(inValue);
        }
    }
}

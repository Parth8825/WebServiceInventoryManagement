//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceInventoryManagement.OrderServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderBO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class OrderBO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int OrderNoField;
        
        private double PurchAmtField;
        
        private System.DateTime OrderDateField;
        
        private int CustomerIdField;
        
        private int SalesmanIdField;
        
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
        public int OrderNo {
            get {
                return this.OrderNoField;
            }
            set {
                if ((this.OrderNoField.Equals(value) != true)) {
                    this.OrderNoField = value;
                    this.RaisePropertyChanged("OrderNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double PurchAmt {
            get {
                return this.PurchAmtField;
            }
            set {
                if ((this.PurchAmtField.Equals(value) != true)) {
                    this.PurchAmtField = value;
                    this.RaisePropertyChanged("PurchAmt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderServiceReference.OrderServiceSoap")]
    public interface OrderServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetOrderResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrder", ReplyAction="*")]
        WebServiceInventoryManagement.OrderServiceReference.GetOrderResponse GetOrder(WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.GetOrderResponse> GetOrderAsync(WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest request);
        
        // CODEGEN: Generating message contract since element name newOrder from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNewOrder", ReplyAction="*")]
        WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponse InsertNewOrder(WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertNewOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponse> InsertNewOrderAsync(WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest request);
        
        // CODEGEN: Generating message contract since element name order from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateOrder", ReplyAction="*")]
        WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponse UpdateOrder(WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponse> UpdateOrderAsync(WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest request);
        
        // CODEGEN: Generating message contract since element name order from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteOrder", ReplyAction="*")]
        WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponse DeleteOrder(WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteOrder", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponse> DeleteOrderAsync(WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrder", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.GetOrderRequestBody Body;
        
        public GetOrderRequest() {
        }
        
        public GetOrderRequest(WebServiceInventoryManagement.OrderServiceReference.GetOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetOrderRequestBody {
        
        public GetOrderRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.GetOrderResponseBody Body;
        
        public GetOrderResponse() {
        }
        
        public GetOrderResponse(WebServiceInventoryManagement.OrderServiceReference.GetOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.OrderBO[] GetOrderResult;
        
        public GetOrderResponseBody() {
        }
        
        public GetOrderResponseBody(WebServiceInventoryManagement.OrderServiceReference.OrderBO[] GetOrderResult) {
            this.GetOrderResult = GetOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNewOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNewOrder", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequestBody Body;
        
        public InsertNewOrderRequest() {
        }
        
        public InsertNewOrderRequest(WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNewOrderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.OrderBO newOrder;
        
        public InsertNewOrderRequestBody() {
        }
        
        public InsertNewOrderRequestBody(WebServiceInventoryManagement.OrderServiceReference.OrderBO newOrder) {
            this.newOrder = newOrder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertNewOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertNewOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponseBody Body;
        
        public InsertNewOrderResponse() {
        }
        
        public InsertNewOrderResponse(WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertNewOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertNewOrderResult;
        
        public InsertNewOrderResponseBody() {
        }
        
        public InsertNewOrderResponseBody(int InsertNewOrderResult) {
            this.InsertNewOrderResult = InsertNewOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateOrder", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequestBody Body;
        
        public UpdateOrderRequest() {
        }
        
        public UpdateOrderRequest(WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateOrderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.OrderBO order;
        
        public UpdateOrderRequestBody() {
        }
        
        public UpdateOrderRequestBody(WebServiceInventoryManagement.OrderServiceReference.OrderBO order) {
            this.order = order;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponseBody Body;
        
        public UpdateOrderResponse() {
        }
        
        public UpdateOrderResponse(WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdateOrderResult;
        
        public UpdateOrderResponseBody() {
        }
        
        public UpdateOrderResponseBody(int UpdateOrderResult) {
            this.UpdateOrderResult = UpdateOrderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteOrderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteOrder", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequestBody Body;
        
        public DeleteOrderRequest() {
        }
        
        public DeleteOrderRequest(WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteOrderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.OrderBO order;
        
        public DeleteOrderRequestBody() {
        }
        
        public DeleteOrderRequestBody(WebServiceInventoryManagement.OrderServiceReference.OrderBO order) {
            this.order = order;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteOrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DeleteOrderResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponseBody Body;
        
        public DeleteOrderResponse() {
        }
        
        public DeleteOrderResponse(WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DeleteOrderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int DeleteOrderResult;
        
        public DeleteOrderResponseBody() {
        }
        
        public DeleteOrderResponseBody(int DeleteOrderResult) {
            this.DeleteOrderResult = DeleteOrderResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OrderServiceSoapChannel : WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceSoapClient : System.ServiceModel.ClientBase<WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap>, WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap {
        
        public OrderServiceSoapClient() {
        }
        
        public OrderServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.OrderServiceReference.GetOrderResponse WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.GetOrder(WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest request) {
            return base.Channel.GetOrder(request);
        }
        
        public WebServiceInventoryManagement.OrderServiceReference.OrderBO[] GetOrder() {
            WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.GetOrderRequestBody();
            WebServiceInventoryManagement.OrderServiceReference.GetOrderResponse retVal = ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).GetOrder(inValue);
            return retVal.Body.GetOrderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.GetOrderResponse> WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.GetOrderAsync(WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest request) {
            return base.Channel.GetOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.GetOrderResponse> GetOrderAsync() {
            WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.GetOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.GetOrderRequestBody();
            return ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).GetOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponse WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.InsertNewOrder(WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest request) {
            return base.Channel.InsertNewOrder(request);
        }
        
        public int InsertNewOrder(WebServiceInventoryManagement.OrderServiceReference.OrderBO newOrder) {
            WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequestBody();
            inValue.Body.newOrder = newOrder;
            WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponse retVal = ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).InsertNewOrder(inValue);
            return retVal.Body.InsertNewOrderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponse> WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.InsertNewOrderAsync(WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest request) {
            return base.Channel.InsertNewOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderResponse> InsertNewOrderAsync(WebServiceInventoryManagement.OrderServiceReference.OrderBO newOrder) {
            WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.InsertNewOrderRequestBody();
            inValue.Body.newOrder = newOrder;
            return ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).InsertNewOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponse WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.UpdateOrder(WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest request) {
            return base.Channel.UpdateOrder(request);
        }
        
        public int UpdateOrder(WebServiceInventoryManagement.OrderServiceReference.OrderBO order) {
            WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequestBody();
            inValue.Body.order = order;
            WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponse retVal = ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).UpdateOrder(inValue);
            return retVal.Body.UpdateOrderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponse> WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.UpdateOrderAsync(WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest request) {
            return base.Channel.UpdateOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.UpdateOrderResponse> UpdateOrderAsync(WebServiceInventoryManagement.OrderServiceReference.OrderBO order) {
            WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.UpdateOrderRequestBody();
            inValue.Body.order = order;
            return ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).UpdateOrderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponse WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.DeleteOrder(WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest request) {
            return base.Channel.DeleteOrder(request);
        }
        
        public int DeleteOrder(WebServiceInventoryManagement.OrderServiceReference.OrderBO order) {
            WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequestBody();
            inValue.Body.order = order;
            WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponse retVal = ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).DeleteOrder(inValue);
            return retVal.Body.DeleteOrderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponse> WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap.DeleteOrderAsync(WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest request) {
            return base.Channel.DeleteOrderAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceInventoryManagement.OrderServiceReference.DeleteOrderResponse> DeleteOrderAsync(WebServiceInventoryManagement.OrderServiceReference.OrderBO order) {
            WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest inValue = new WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequest();
            inValue.Body = new WebServiceInventoryManagement.OrderServiceReference.DeleteOrderRequestBody();
            inValue.Body.order = order;
            return ((WebServiceInventoryManagement.OrderServiceReference.OrderServiceSoap)(this)).DeleteOrderAsync(inValue);
        }
    }
}

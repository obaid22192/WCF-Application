﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backoffice.backoffice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MyWebshopContract")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="item", Namespace="http://schemas.datacontract.org/2004/07/MyWebshopContract")]
    [System.SerializableAttribute()]
    public partial class item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
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
        public double Price {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/MyWebshopContract")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime MomentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
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
        public System.DateTime Moment {
            get {
                return this.MomentField;
            }
            set {
                if ((this.MomentField.Equals(value) != true)) {
                    this.MomentField = value;
                    this.RaisePropertyChanged("Moment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="MyWebshopContract", ConfigurationName="backoffice.IWebshop", CallbackContract=typeof(Backoffice.backoffice.IWebshopCallback))]
    public interface IWebshop {
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetData", ReplyAction="MyWebshopContract/IWebshop/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetData", ReplyAction="MyWebshopContract/IWebshop/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetDataUsingDataContract", ReplyAction="MyWebshopContract/IWebshop/GetDataUsingDataContractResponse")]
        Backoffice.backoffice.CompositeType GetDataUsingDataContract(Backoffice.backoffice.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetDataUsingDataContract", ReplyAction="MyWebshopContract/IWebshop/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Backoffice.backoffice.CompositeType> GetDataUsingDataContractAsync(Backoffice.backoffice.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetWebshopName", ReplyAction="MyWebshopContract/IWebshop/GetWebshopNameResponse")]
        string GetWebshopName();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetWebshopName", ReplyAction="MyWebshopContract/IWebshop/GetWebshopNameResponse")]
        System.Threading.Tasks.Task<string> GetWebshopNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductList", ReplyAction="MyWebshopContract/IWebshop/GetProductListResponse")]
        System.Collections.Generic.List<Backoffice.backoffice.item> GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductList", ReplyAction="MyWebshopContract/IWebshop/GetProductListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Backoffice.backoffice.item>> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductInfo", ReplyAction="MyWebshopContract/IWebshop/GetProductInfoResponse")]
        string GetProductInfo(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/GetProductInfo", ReplyAction="MyWebshopContract/IWebshop/GetProductInfoResponse")]
        System.Threading.Tasks.Task<string> GetProductInfoAsync(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/BuyProduct", ReplyAction="MyWebshopContract/IWebshop/BuyProductResponse")]
        bool BuyProduct(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/BuyProduct", ReplyAction="MyWebshopContract/IWebshop/BuyProductResponse")]
        System.Threading.Tasks.Task<bool> BuyProductAsync(string productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebshopCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="MyWebshopContract/IWebshop/productShipped", ReplyAction="MyWebshopContract/IWebshop/productShippedResponse")]
        void productShipped(string productId, System.DateTime shippingMoment);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebshopChannel : Backoffice.backoffice.IWebshop, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebshopClient : System.ServiceModel.DuplexClientBase<Backoffice.backoffice.IWebshop>, Backoffice.backoffice.IWebshop {
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Backoffice.backoffice.CompositeType GetDataUsingDataContract(Backoffice.backoffice.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Backoffice.backoffice.CompositeType> GetDataUsingDataContractAsync(Backoffice.backoffice.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public string GetWebshopName() {
            return base.Channel.GetWebshopName();
        }
        
        public System.Threading.Tasks.Task<string> GetWebshopNameAsync() {
            return base.Channel.GetWebshopNameAsync();
        }
        
        public System.Collections.Generic.List<Backoffice.backoffice.item> GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Backoffice.backoffice.item>> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public string GetProductInfo(string ProductId) {
            return base.Channel.GetProductInfo(ProductId);
        }
        
        public System.Threading.Tasks.Task<string> GetProductInfoAsync(string ProductId) {
            return base.Channel.GetProductInfoAsync(ProductId);
        }
        
        public bool BuyProduct(string productId) {
            return base.Channel.BuyProduct(productId);
        }
        
        public System.Threading.Tasks.Task<bool> BuyProductAsync(string productId) {
            return base.Channel.BuyProductAsync(productId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="backoffice.IBackoffice", CallbackContract=typeof(Backoffice.backoffice.IBackofficeCallback))]
    public interface IBackoffice {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackoffice/Subscribe", ReplyAction="http://tempuri.org/IBackoffice/SubscribeResponse")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackoffice/Subscribe", ReplyAction="http://tempuri.org/IBackoffice/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackoffice/GetOrderList", ReplyAction="http://tempuri.org/IBackoffice/GetOrderListResponse")]
        System.Collections.Generic.List<Backoffice.backoffice.Order> GetOrderList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackoffice/GetOrderList", ReplyAction="http://tempuri.org/IBackoffice/GetOrderListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Backoffice.backoffice.Order>> GetOrderListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackoffice/ShipOrder", ReplyAction="http://tempuri.org/IBackoffice/ShipOrderResponse")]
        bool ShipOrder(string ProductId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBackoffice/ShipOrder", ReplyAction="http://tempuri.org/IBackoffice/ShipOrderResponse")]
        System.Threading.Tasks.Task<bool> ShipOrderAsync(string ProductId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBackofficeCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBackoffice/OnEvent")]
        void OnEvent(string PId, System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBackofficeChannel : Backoffice.backoffice.IBackoffice, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BackofficeClient : System.ServiceModel.DuplexClientBase<Backoffice.backoffice.IBackoffice>, Backoffice.backoffice.IBackoffice {
        
        public BackofficeClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public BackofficeClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public BackofficeClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BackofficeClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BackofficeClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public System.Collections.Generic.List<Backoffice.backoffice.Order> GetOrderList() {
            return base.Channel.GetOrderList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Backoffice.backoffice.Order>> GetOrderListAsync() {
            return base.Channel.GetOrderListAsync();
        }
        
        public bool ShipOrder(string ProductId) {
            return base.Channel.ShipOrder(ProductId);
        }
        
        public System.Threading.Tasks.Task<bool> ShipOrderAsync(string ProductId) {
            return base.Channel.ShipOrderAsync(ProductId);
        }
    }
}

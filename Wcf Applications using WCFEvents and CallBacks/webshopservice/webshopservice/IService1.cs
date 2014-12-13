using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace MyWebshopContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [DataContract]
    public class item
    {
       
       [DataMember]
        public string ProductId { get; set; }
       // [NonSerialized]
        public string ProductInfo { get; set; }
      [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Stock { get; set; }

        public bool OnSale { get; set; }
        public item(string pid, string pinfo, double price, int stock, bool onsale)
        {
            ProductId = pid;
            ProductInfo = pinfo;
            Price = price;
            Stock = stock;
            OnSale = onsale;
        }
    }
    [ServiceContract(Namespace = "MyWebshopContract", CallbackContract = typeof(IWebshopCallback))]
   
    public interface IWebshop
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        string GetWebshopName();
        [OperationContract]
        List<item> GetProductList();
        [OperationContract]
        string GetProductInfo(string ProductId);
        [OperationContract]
        bool BuyProduct(string productId);
        void Add(item s);
       
    }
    [DataContract]
    public class Order
    {
       
        [DataMember]
        public string ProductId { get; set; }

        [DataMember]
        public DateTime Moment { get; set; }

        public IWebshopCallback WebshopCallback { get; set; }
        public Order(string pid, DateTime dt, IWebshopCallback icall)
        {
            ProductId = pid;
            Moment = dt;
            WebshopCallback = icall;
        }
    }
    public interface IWebshopCallback
    {
        [OperationContract]
        void productShipped(string productId, DateTime shippingMoment);
    }
 
     interface IMyEvents
    {
        [OperationContract(IsOneWay = true)]
        void OnEvent(string PId , DateTime date);
       
    }
    [ServiceContract(CallbackContract = typeof(IMyEvents))]
    public interface IBackoffice
    {
        [OperationContract]
        void Subscribe();
        [OperationContract]
        List<Order> GetOrderList();

        [OperationContract]
        bool ShipOrder(string ProductId);
        

    }
    
   


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "webshopservice.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}

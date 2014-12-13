using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWebshopContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant,UseSynchronizationContext = false)]
  //[CallbackBehavior(UseSynchronizationContext = false)] 
   
    public class Cwebshop : IWebshop,IBackoffice
    {
        public List<item> items;
        public List<Order> order;
        public static IWebshopCallback callback;
        public  static Action<string,DateTime> m_event = delegate{};
        IMyEvents subscriber;


        public Cwebshop()
        {
            items = new List<item>();
            order = new List<Order>();
            items.Add(new item("0001", "Book1", 100.00, 19, false));
            items.Add(new item("0002", "Book2", 10.00, 122, false));
            items.Add(new item("0003", "Book3", 90.00, 120, false));
            items.Add(new item("0004", "Book4", 80.1, 10, false));
        }
        
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
           
        }
        

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }





        public string GetWebshopName()
        {
            return "Obaid Book Shop";
        }

        public List<item> GetProductList()
        {
            return items;
        }

        public string GetProductInfo(string ProductId)
        {
            foreach (item i in items)
            {
                if (i.ProductId==ProductId)
                {
                    return i.ProductInfo;
                }
               
            }
            return "No item found";
        }

        public bool BuyProduct(string productId)
        {
            foreach (item i in items)
            {
                if (productId == i.ProductId)
                {
                    i.Stock = i.Stock - 1 ;
                    callback =OperationContext.Current.GetCallbackChannel<IWebshopCallback>();
                    order.Add(new Order(productId, DateTime.Now,callback));
                    FireEvent(i.ProductId,DateTime.Now);
                    return true;
                }
            }
            return false;
        }
        public static void FireEvent(string pid ,DateTime date)
        {
            m_event(pid , date);
        }


        public void Add(item s)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderList()
        {
            return order;
        }

        public bool ShipOrder(string ProductId)
        {
            foreach (Order o in order)
            { 
             if (ProductId == o.ProductId)
                {
                    o.WebshopCallback.productShipped(ProductId, DateTime.Now);
                    removeorder(o);
                    return true;
             }
             
            }
            return false;
        }
        public void removeorder(Order o)
        {
            order.Remove(o);
            
        }

        public void Subscribe()
        {
            subscriber = OperationContext.Current.GetCallbackChannel<IMyEvents>();
            m_event += subscriber.OnEvent;
          
        }
    }
}

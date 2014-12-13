using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopClient.MywebShopservice;
using System.Windows.Forms;

namespace WebShopClient
{
    class callbackclient:IWebshopCallback
    {
        Label lab;
        public callbackclient(Label l)
        {
            lab = l;
        }

        public void productShipped(string productId, DateTime shippingMoment)
        {
            lab.Text = productId + " was Shipped at " + shippingMoment; 
        }
    }
}

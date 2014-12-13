using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backoffice.backoffice;
using System.ServiceModel;
namespace Backoffice
{
    public partial class Form1 : Form 

    {
        backoffice.BackofficeClient proxy;
        backoffice.IBackofficeCallback subscriber;
       
        public Form1()
        {
            InitializeComponent();
            subscriber = new iEvent(this);
             InstanceContext context = new InstanceContext(subscriber);
             proxy = new BackofficeClient(context);
             proxy.Subscribe();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnupdateorder_Click(object sender, EventArgs e)
        {
            refreshorder();
        }

        private void btnshiporder_Click(object sender, EventArgs e)
        {
            string id = lbid.SelectedItem.ToString();
            bool check = proxy.ShipOrder(id);
            if (check)
            {
                lblinfo.Text = "order ID: " + id + " Shipped at " + DateTime.Now.ToString();
            }
            else
            {
                lblinfo.Text = "order ID: " + id + " Shipped at has not shipped sucessfully ";
            }
            refreshorder();
        }
        public void refreshorder()
        {
            lbid.Items.Clear();
            lbtime.Items.Clear();
            List<backoffice.Order> order = proxy.GetOrderList();
            foreach (backoffice.Order o in order)
            {
                lbid.Items.Add(o.ProductId);
                lbtime.Items.Add(o.Moment.ToString());
            }
        }
    }
    public class iEvent : backoffice.IBackofficeCallback
    {
        Form1 f;
        
        public iEvent(Form1 fo)
        {
            f = fo;
        }
        

        public void OnEvent(string PId, DateTime date)
        {
            f.lbid.Items.Add(PId);
            f.lbtime.Items.Add(date.ToString());

        }
    }
   
    
   
}

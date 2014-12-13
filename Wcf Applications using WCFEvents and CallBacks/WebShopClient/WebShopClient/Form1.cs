using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WebShopClient
{
    public partial class Form1 : Form
    {
       // MyweShopservice.WebshopClient proxy;
        public MywebShopservice.IWebshopCallback callback;
       MywebShopservice.WebshopClient proxy;
        

        public Form1()
        {
            InitializeComponent();
            callback = new callbackclient(lblinfo);
             InstanceContext context = new InstanceContext(callback);
              proxy = new MywebShopservice.WebshopClient(context);

        }

        private void btnname_Click(object sender, EventArgs e)
        {
            MessageBox.Show(proxy.GetWebshopName());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(proxy.GetProductInfo(listBox1.SelectedItem.ToString()));
        }

        private void btnproductlist_Click(object sender, EventArgs e)
        {
            getproducts();
            
        }

        private void btnproductinfo_Click(object sender, EventArgs e)
        {
            try
            {
                string info = proxy.GetProductInfo(listBox1.SelectedItem.ToString());
                MessageBox.Show(info);
            }
            catch
            {
                MessageBox.Show("please Select Item from list");
            }
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            string temp = listBox1.SelectedItem.ToString();
            bool check =proxy.BuyProduct(temp);
            
            getproducts();
            if (check)
            {
                lblinfo.Text="You Have Bought: "+ proxy.GetProductInfo(temp)+ " at "+ DateTime.Now ;
                
            }
          
        }
        private void getproducts()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            List<MywebShopservice.item> item1 = proxy.GetProductList();
            foreach (MywebShopservice.item i in item1)
            {
                listBox1.Items.Add(i.ProductId);
                listBox2.Items.Add(i.Price.ToString());
                listBox3.Items.Add(i.Stock.ToString());

            }
        }
    }
}

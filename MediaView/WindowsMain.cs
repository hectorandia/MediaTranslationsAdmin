using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MediaAdmin.MediaEntity;

namespace MediaView
{
    public partial class WindowsMain : MetroFramework.Forms.MetroForm
    {
        public WindowsMain()
        {
            InitializeComponent();
        }

        private void WindowsMain_Load(object sender, EventArgs e)
        {
            EFDbMediaTranslations dbMedia = new EFDbMediaTranslations();
            Customers customer = new Customers();
            //var customers = dbMedia.Customers;
            //customers.Create();
            customer.Address = "Test calle 13";
            customer.Name = "Hector Tito";
            customer.City = "Iquique";
            dbMedia.Customers.Add(customer);
            dbMedia.SaveChanges();
            
        }
    }
}

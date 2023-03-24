using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL.Forms.AdminMenu.FormsAdminMenu
{
    public partial class EditCustomer : Form
    {
        private CustomerManagement customerManagement;

        public EditCustomer()
        {
            InitializeComponent();
        }

        public EditCustomer(CustomerManagement customerManagement)
        {
            InitializeComponent();
            this.customerManagement = customerManagement;
        }
    }
}

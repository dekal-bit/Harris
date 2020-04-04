using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            
                
                PersonalForm personalForm = new PersonalForm();
                personalForm.Show();
            
        }

        private void btnBusiness_Click(object sender, EventArgs e)
        {
            BusinessForm businessForm = new BusinessForm();
            businessForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

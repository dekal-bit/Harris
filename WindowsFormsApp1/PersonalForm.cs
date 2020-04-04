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
    public partial class PersonalForm : Form
    {
        DbConn dbConn = new DbConn();

        public PersonalForm()
        {
            InitializeComponent();
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            DGBpersonal.DataSource = dbConn.getAllPersonal();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DGBpersonal.DataSource = dbConn.getAllPersonal();
        }

        private void DGBpersonal_CellClick(object sender, EventArgs e)
        {
        
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbAddress.Enabled = true;
            tbPostcode.Enabled = true;
            tbCity.Enabled = true;
            tbCompany.Enabled = true;
            tbEmail.Enabled = true;
            tbConTel.Enabled = true;
            tbHomeTel.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveNew.Enabled = true;
            tbFname.Text = String.Empty;
            tbLname.Text = String.Empty;
            tbAddress.Text = String.Empty;
            tbPostcode.Text = String.Empty;
            tbCity.Text = String.Empty;
            tbCompany.Text = String.Empty;
            tbEmail.Text = String.Empty;
            tbConTel.Text = String.Empty;
            tbHomeTel.Text = String.Empty;


        }

        private void DGBpersonal_CellClick(object sender, MouseEventArgs e)
        {
            int index = Int32.Parse(DGBpersonal.SelectedCells[0].Value.ToString());
            tbFname.Text = DGBpersonal.SelectedCells[1].Value.ToString();
            tbLname.Text = DGBpersonal.SelectedCells[2].Value.ToString();
            tbAddress.Text = DGBpersonal.SelectedCells[3].Value.ToString();
            tbPostcode.Text = DGBpersonal.SelectedCells[4].Value.ToString();
            tbCity.Text = DGBpersonal.SelectedCells[5].Value.ToString();
            tbCompany.Text = DGBpersonal.SelectedCells[6].Value.ToString();
            tbEmail.Text = DGBpersonal.SelectedCells[7].Value.ToString();
            tbConTel.Text = DGBpersonal.SelectedCells[8].Value.ToString();
            tbHomeTel.Text = DGBpersonal.SelectedCells[9].Value.ToString();

        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactFName = tbFname.Text;
            personalContact.ContactLName = tbLname.Text;
            personalContact.ContactAddress = tbAddress.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            personalContact.ContactCity = tbCity.Text;
            personalContact.ContactCompany = tbCompany.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.ContactTel = tbConTel.Text;
            personalContact.PersonalHomeTel = tbHomeTel.Text;
            dbConn.InsertPersonal(personalContact);
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbAddress.Enabled = false;
            tbPostcode.Enabled = false;
            tbCity.Enabled = false;
            tbCompany.Enabled = false;
            tbEmail.Enabled = false;
            tbConTel.Enabled = false;
            tbHomeTel.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveNew.Enabled = true;
            DGBpersonal.DataSource = dbConn.getAllPersonal();






        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbFname.Enabled = true;
            tbLname.Enabled = true;
            tbAddress.Enabled = true;
            tbPostcode.Enabled = true;
            tbCity.Enabled = true;
            tbCompany.Enabled = true;
            tbEmail.Enabled = true;
            tbConTel.Enabled = true;
            tbHomeTel.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveSelected.Enabled = true;
            btnAddNew.Enabled = false;



        }

        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(DGBpersonal.SelectedCells[0].Value.ToString());
            PersonalContact personalContact = new PersonalContact();
            personalContact.ContactID = index;
            personalContact.ContactFName = tbFname.Text;
            personalContact.ContactLName = tbLname.Text;
            personalContact.ContactAddress = tbAddress.Text;
            personalContact.ContactPostcode = tbPostcode.Text;
            personalContact.ContactCity = tbCity.Text;
            personalContact.ContactCompany = tbCompany.Text;
            personalContact.ContactEmail = tbEmail.Text;
            personalContact.ContactTel = tbConTel.Text;
            personalContact.PersonalHomeTel = tbHomeTel.Text;
            dbConn.UpdatePersonal(personalContact);
            DGBpersonal.DataSource = dbConn.getAllPersonal();
            tbFname.Enabled = false;
            tbLname.Enabled = false;
            tbAddress.Enabled = false;
            tbPostcode.Enabled = false;
            tbCity.Enabled = false;
            tbCompany.Enabled = false ;
            tbEmail.Enabled = false ;
            tbConTel.Enabled = false;
            tbHomeTel.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveSelected.Enabled = false;
            btnAddNew.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string messege = "Are you sure you want to Delete?";
            string caption = "Do you want to delete the contact with the record with ID of " + Int32.Parse(DGBpersonal.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(messege, caption, buttons);
            if (result == DialogResult.Yes)
            {
                dbConn.DeltePersonal (Int32.Parse(DGBpersonal.SelectedCells[0].Value.ToString()));
                DGBpersonal.DataSource = dbConn.getAllPersonal();

            }


        }
    }


}

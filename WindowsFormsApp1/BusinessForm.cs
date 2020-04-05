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
    public partial class BusinessForm : Form
    {

        DbConn dbConn = new DbConn();

        public BusinessForm()
        {
            InitializeComponent();
        }

        private void BusinessForm_Load(object sender, EventArgs e)
        {
            DBGbusiness.DataSource = dbConn.getAllBusiness();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DBGbusiness.DataSource = dbConn.getAllBusiness();
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            TbBusinessName.Enabled = true;
            TbOrder.Enabled = true;
            TbAddress.Enabled = true;
            TbPostcode.Enabled = true;
            TbCity.Enabled = true;
            TbEmail.Enabled = true;
            TbBusinessTel.Enabled = true;
            TbHomeTel.Enabled = true;
            btnSaveSelected.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveNew.Enabled = true;
            TbBusinessTel.Text = String.Empty;
            TbOrder.Text = String.Empty;
            TbAddress.Text = String.Empty;
            TbPostcode.Text = String.Empty;
            TbCity.Text = String.Empty;
            TbEmail.Text = String.Empty;
            TbBusinessName.Text = String.Empty;
            TbHomeTel.Text = String.Empty;

        }



        private void DBGbusiness_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Int32.Parse(DBGbusiness.SelectedCells[0].Value.ToString());
            TbBusinessName.Text = DBGbusiness.SelectedCells[1].Value.ToString();
            TbOrder.Text = DBGbusiness.SelectedCells[2].Value.ToString();
            TbAddress.Text = DBGbusiness.SelectedCells[3].Value.ToString();
            TbPostcode.Text = DBGbusiness.SelectedCells[4].Value.ToString();
            TbCity.Text = DBGbusiness.SelectedCells[5].Value.ToString();
            TbEmail.Text = DBGbusiness.SelectedCells[6].Value.ToString();
            TbBusinessTel.Text = DBGbusiness.SelectedCells[7].Value.ToString();
            TbHomeTel.Text = DBGbusiness.SelectedCells[8].Value.ToString();
        }


        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            BusinessContact businessContact = new BusinessContact();
            businessContact.BusinessFName = TbBusinessName.Text;
            businessContact.BusinessOrder = TbOrder.Text;
            businessContact.BussinessAddress = TbAddress.Text;
            businessContact.BusinessPostcode = TbPostcode.Text;
            businessContact.BusinessCity = TbCity.Text;
            businessContact.BusinessEmail = TbEmail.Text;
            businessContact.BusinessTel = TbBusinessTel.Text;
            businessContact.BusinessHomeTel = TbHomeTel.Text;
            dbConn.InsertBusiness(businessContact);
            DBGbusiness.DataSource = dbConn.getAllBusiness();
            TbBusinessName.Enabled = false;
            TbOrder.Enabled = false;
            TbAddress.Enabled = false;
            TbPostcode.Enabled = false;
            TbCity.Enabled = false;
            TbEmail.Enabled = false;
            TbBusinessTel.Enabled = false;
            TbHomeTel.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveNew.Enabled = true;
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TbBusinessName.Enabled = true;
            TbOrder.Enabled = true;
            TbAddress.Enabled = true;
            TbPostcode.Enabled = true;
            TbCity.Enabled = true;
            TbEmail.Enabled = true;
            TbBusinessTel.Enabled = true;
            TbHomeTel.Enabled = true;
            btnAddNew.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveNew.Enabled = false;
            btnSaveSelected.Enabled = true;
        }


        private void btnSaveSelected_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(DBGbusiness.SelectedCells[0].Value.ToString());
            BusinessContact businessContact = new BusinessContact();
            businessContact.BusinessID = index;
            businessContact.BusinessFName = TbBusinessName.Text;
            businessContact.BusinessOrder = TbOrder.Text;
            businessContact.BussinessAddress = TbAddress.Text;
            businessContact.BusinessPostcode = TbPostcode.Text;
            businessContact.BusinessCity = TbCity.Text;
            businessContact.BusinessEmail = TbEmail.Text;
            businessContact.BusinessTel = TbBusinessTel.Text;
            businessContact.BusinessHomeTel = TbHomeTel.Text;
            dbConn.UpdateBusiness(businessContact);
            DBGbusiness.DataSource = dbConn.getAllBusiness();
            TbBusinessName.Enabled = false;
            TbOrder.Enabled = false;
            TbAddress.Enabled = false;
            TbPostcode.Enabled = false;
            TbCity.Enabled = false;
            TbEmail.Enabled = false;
            TbBusinessTel.Enabled = false;
            TbHomeTel.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSaveSelected.Enabled = false;
            btnAddNew.Enabled = true;

        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string messege = "Are you sure you want to Delete?";
            string caption = "Do you want to delete the contact with the record with ID of " + Int32.Parse(DBGbusiness.SelectedCells[0].Value.ToString());
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(messege, caption, buttons);
            if (result == DialogResult.Yes)
            {
                dbConn.DelteBusiness(Int32.Parse(DBGbusiness.SelectedCells[0].Value.ToString()));
                DBGbusiness.DataSource = dbConn.getAllBusiness();

            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            Close();
            (new WelcomeForm()).Show();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }


    }

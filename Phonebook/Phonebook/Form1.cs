using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonebook.EntityFramework;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        private phonebookEntities3 database;

        public Form1()
        {
            //create database instance
            database = new EntityFramework.phonebookEntities3();
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new PopupEffect.transparentBg(this, new frmAddContact());
        }

        private void BtnTab_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            //reload data here
            PopulateDatatoDatagrid();
        }

        void PopulateDatatoDatagrid()
        {

            //load data from database
            var result = database.ybl_contact.Select(r => r);

            //filter search
            if (txtSearch.Text.Trim().Length > 0)
            {
                result = result.Where(r => r.name.Contains(txtSearch.Text.Trim().ToLower()) || r.phone.Contains(txtSearch.Text.Trim().ToLower()));

            }


            grid.Rows.Clear();
            foreach (var contact in result)
            {
                grid.Rows.Add(
                    new object[]
                {
                        contact.name,
                        contact.email,
                        contact.phone,
                        contact.address,
                }
            );
                grid.Rows[grid.RowCount - 1].Tag = contact;
            }
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            PopulateDatatoDatagrid();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            //reload data here
            PopulateDatatoDatagrid();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            //reload data here
            PopulateDatatoDatagrid();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            //reload data here
            PopulateDatatoDatagrid();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            //reload data here
            PopulateDatatoDatagrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Delete Selected Row
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                var contact = (ybl_contact)row.Tag;
                database.ybl_contact.Remove(contact);
                grid.Rows.Remove(row);
            }

            //Save Changes
            if (database.ChangeTracker.HasChanges())
            {

                if (database.SaveChanges() > 0)
                {
                    MessageBox.Show("Success Deleted Contact");
                    
                }
                else
                {
                    MessageBox.Show("Failed Deleted  Contact");
                    
                }
            }
        }
    }
}

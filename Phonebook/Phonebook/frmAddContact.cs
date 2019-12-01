using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Phonebook.EntityFramework;

namespace Phonebook
{
    public partial class frmAddContact : Form
    {
        private phonebookEntities3 database;

        public frmAddContact()
        {
            //create database instance
            database = new EntityFramework.phonebookEntities3();
            InitializeComponent();
            txtPhone.KeyPress += new KeyPressEventHandler(TxtPhone_KeyPress);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddContact_Load(object sender, EventArgs e)
        {

        }

        private void BunifuTextBox3_TextChange(object sender, EventArgs e)
        {

        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' ) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void TxtEmail_TextChange(object sender, EventArgs e)
        {

           /* try
            {
                var eMailValidator = new System.Net.Mail.MailAddress("xyz@blabla.com");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            //do validate here
            database.ybl_contact.Add(
                new ybl_contact()
                {
                    contactID = database.ybl_contact.Count(),
                    name = txtName.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    phone = txtPhone.Text.Trim(),
                    address = txtAddress.Text.Trim(),
                    isFriend = inFriend.Checked,
                    isBussiness = inBussiness.Checked,
                    isCowokers = inCowokers.Checked,
                    isFamily = inFamily.Checked

                }
                ); ;

                 //Save Changes


                if (database.SaveChanges() > 0)
                {
                    MessageBox.Show("Success Added New Contact");
                //this.Close();
                }
                else
                {
                    MessageBox.Show("Failed Added New Contact");
                }
                //that it
            
        }
    }
}
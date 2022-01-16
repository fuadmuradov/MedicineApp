using MedicineApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MedicineApp.Extension;

namespace MedicineApp
{
    public partial class Form1 : Form
    {
        private readonly MedicineEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new MedicineEntities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim();
            string fullname = txtFname.Text.Trim();
            string password = txtPassword.Text.Trim();
            string reppassword = txtRPTpassword.Text.Trim();

            if(!isValid(email, fullname, password, reppassword))
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool emailDB = db.Users.Any(x => x.Email == email);

            if (emailDB)
            {
                MessageBox.Show("Mail Already exist", "Warninig",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                Fullname = fullname,
                Passwordd = Cryptography.Encode(password),
                Email = email,
                isAdmin = false,
                isActive = true,
                isDeleteted = false
            };

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Register Saccesfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login lg = new Login();
            lg.Show();
            this.Close();

        }

        private bool isValid(string email, string fullname, string password, string rpassword)
        {
            if(email=="" || fullname=="" || password=="" || rpassword =="")
            {
                MessageBox.Show("Fill all Textbox Please!!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!email.Contains("@"))
            {
                return false;
            }
            if(password != rpassword)
            {
                MessageBox.Show("Please Repead password Correctly!!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
        }
    }
}

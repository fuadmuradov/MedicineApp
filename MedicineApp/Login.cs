using MedicineApp.Extension;
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

namespace MedicineApp
{
    public partial class Login : Form
    {
        private readonly MedicineEntities db;
        public Login()
        {
            InitializeComponent();
            db = new MedicineEntities();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtMail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if(email == "" || password == "")
            {
                MessageBox.Show("Please Fill all Textbox", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string encryptpass = Cryptography.Encode(password);

            User userResult = db.Users.FirstOrDefault(u => u.Email == email);

            if(userResult == null)
            {
                MessageBox.Show("This Mail is not Exist !!!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(userResult.Passwordd != encryptpass)
            {
                MessageBox.Show("This Password Is Not Correct !!!", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dashboard dshb = new Dashboard();
            dshb.Show();
            this.Hide();


        }
    }
}

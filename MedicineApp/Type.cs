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
using MedicineApp.Models;
namespace MedicineApp
{
    public partial class Type : Form
    {
        private readonly MedicineEntities db;
        public Type()
        {
            InitializeComponent();
            db = new MedicineEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typename = textBox1.Text.Trim();

            if(typename == "")
            {
                MessageBox.Show("please fill TypeName !!", "Warninig",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(db.Types.Any(t=>t.Name == typename))
            {
                MessageBox.Show("This Type Already Exist !!", "Warninig",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Models.Type ttype = new Models.Type
            {
                Name = typename
            };

            db.Types.Add(ttype);
            db.SaveChanges();
            this.Close();
        }
    }
}

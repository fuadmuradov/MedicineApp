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
    public partial class Medicine : Form
    {
        private readonly MedicineEntities db;
        public Medicine()
        {
            InitializeComponent();
            db = new MedicineEntities();
        }

        private void btnmedicine_Click(object sender, EventArgs e)
        {
            string mdcntype = cmbtype.SelectedItem.ToString();
            string mdcnname = txtname.Text.Trim();
            int mdcnprice = Convert.ToInt32(txtprice.Value);
            int mdcnamount = Convert.ToInt32(txtamount.Value);

            if(mdcntype=="" || mdcnname=="" || mdcnprice==0 || mdcnamount == 0)
            {
                MessageBox.Show("PFill all Information !!", "Warning",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Models.Type ttype = db.Types.FirstOrDefault(x => x.Name == mdcntype);
            if (ttype == null)
            {
                MessageBox.Show("Select Correct Medicine Type !!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (db.Medicines.Any(x => x.Name == mdcnname))
            {
                MessageBox.Show("This Medicine Already Exist !!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Models.Medicine mdcn = new Models.Medicine{
                Name = mdcnname,
                Price = mdcnprice,
                Amount = mdcnamount,
                TypesId = ttype.id
            };

            db.Medicines.Add(mdcn);
            db.SaveChanges();
            ClearAll();
            Medicine_Load(this, EventArgs.Empty);
            
        }
        private void ClearAll()
        {
            cmbtype.SelectedIndex = 0;
            txtname.Text = "";
            txtprice.Value = 0;
            txtamount.Value = 0;
        }
        private void Medicine_Load(object sender, EventArgs e)
        {
            cmbtype.DataSource = db.Types.Select(x => x.Name).ToList();
            dataGridView1.DataSource = db.Medicines.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int celindex = 0;
           celindex = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (celindex == 0)
            {
                MessageBox.Show("Select cells which Removed !!", "Warning",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Models.Medicine rmvmedicine = db.Medicines.FirstOrDefault(x => x.id == celindex);

            //            MessageBox.Show(rmvmedicine.Name.ToString(), "Warning",
            //MessageBoxButtons.OK, MessageBoxIcon.Warning);

            db.Medicines.Remove(rmvmedicine);
            db.SaveChanges();
            Medicine_Load(this, EventArgs.Empty);
        }
    }
}

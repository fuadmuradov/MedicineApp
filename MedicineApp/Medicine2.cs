using MedicineApp.Models;
using MedicineApp.ViewModels;
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
    public partial class Medicine2 : Form
    {
        private readonly MedicineEntities db;
        public Medicine2()
        {
            InitializeComponent();
            db = new MedicineEntities();
        }

        private void Medicine2_Load(object sender, EventArgs e)
        {
            cmbSelectType.DataSource = db.Types.Where(x => x.Deleted == false).Select(t => new CB_Type
            {
                id = t.id,
                Name = t.Name
            }).ToArray();

            callDataGridView();
            refreshallTextbox();
        }

        private void callDataGridView()
        {
            dtgvMedicine.DataSource = db.Medicines.Where(x => x.isDeleted == false).Select(m => new
            {
                m.Name,
                Type = m.Type.Name,
                m.Amount,
                m.Price

            }).ToList();
        }

        private void refreshallTextbox()
        {
            txtname.Text = "";
            txtAmount.Value = 0;
            txtPrice.Value = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int typeid = ((CB_Type)cmbSelectType.SelectedItem).id;
            string name = txtname.Text.Trim();
            int amount = int.Parse(txtAmount.Value.ToString());
            int price = int.Parse(txtPrice.Value.ToString());

            // MessageBox.Show(id.ToString());

            Models.Medicine medicine = db.Medicines.FirstOrDefault(x => x.Name == name);

            if (name == "")
            {
                MessageBox.Show("Fill Drag Name", "Warning", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (medicine==null)
            {
                Models.Medicine medicineAdd = new Models.Medicine
                {
                    TypesId = typeid,
                    Name = name,
                    Amount = amount,
                    Price = price,
                    isDeleted = false
                };
                db.Medicines.Add(medicineAdd);
            }
            else
            {
                if(price != 0) medicine.Price = price;

                if(amount != 0)medicine.Amount = medicine.Amount + amount;
                
                
                medicine.TypesId = typeid;
            }

            db.SaveChanges();

            callDataGridView();
            refreshallTextbox();
        }

        private void cmbSelectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typeid = ((CB_Type)cmbSelectType.SelectedItem).id;


            dtgvMedicine.DataSource = db.Medicines.Where(x => x.isDeleted == false && x.TypesId == typeid).
                Select(x => new
                {
                    x.Name,
                    Type = x.Type.Name,
                    x.Amount,
                    x.Price
                }).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Select Drag Name", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Models.Medicine medicine = db.Medicines.FirstOrDefault(x => x.Name == name);
            if (medicine != null)
            {
                medicine.isDeleted = true;
                db.SaveChanges();
                callDataGridView();
                refreshallTextbox();
                MessageBox.Show("Drag deleted", "Information",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //  string ss = "12-30-2021";
            //  DateTime EndDate = DateTime.Now;
            //   DateTime StartDate = DateTime.Now.AddDays(+7);
            ////  DateTime StartDate = Convert.ToDateTime(ss);
            //  int dfday = (EndDate.Date - StartDate.Date).Days;
            //  string dtime = DateTime.Now.ToString("yyyy-MM-dd");
            //  MessageBox.Show(StartDate.ToString("yyyy-MM-dd"), "warning", MessageBoxButtons.OK);


            //        MessageBox.Show("Medicine Is Not Exist", "Warning",
            //MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;

        }

        private void dtgvMedicine_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            refreshallTextbox();
            string name = dtgvMedicine.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Models.Medicine medicine = db.Medicines.FirstOrDefault(x => x.Name == name);
            if(medicine != null)
            {
                txtname.Text = medicine.Name;
                txtAmount.Value =Decimal.Parse(medicine.Amount.ToString());
                txtPrice.Value = Decimal.Parse(medicine.Price.ToString());
                cmbSelectType.SelectedIndex = cmbSelectType.FindString(medicine.Type.Name);

            }
        }
    }
}

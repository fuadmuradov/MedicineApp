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
    public partial class TypeDelete : Form
    {
        private readonly MedicineEntities db;
        public TypeDelete()
        {
            db = new MedicineEntities();
            InitializeComponent();
        }

        private void TypeDelete_Load(object sender, EventArgs e)
        {
            cmbtypeDelete.DataSource = db.Types.Where(x => x.Deleted == false).Select(t => new CB_Type
            {
                id = t.id,
                Name = t.Name
            }).ToArray() ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = ((CB_Type)cmbtypeDelete.SelectedItem).id;
            Models.Type ttype = db.Types.Find(id);
            ttype.Deleted = true;
            db.SaveChanges();
        }
    }
}

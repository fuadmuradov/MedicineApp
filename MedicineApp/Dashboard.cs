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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type ttype = new Type();
            ttype.Show();
        }

        private void medicinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Show();
        }

        private void deleteTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeDelete tp = new TypeDelete();
            tp.Show();
           
        }
    }
}

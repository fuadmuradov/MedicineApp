
namespace MedicineApp
{
    partial class Medicine2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvMedicine = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cmbSelectType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMedicine
            // 
            this.dtgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMedicine.Location = new System.Drawing.Point(3, 268);
            this.dtgvMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvMedicine.Name = "dtgvMedicine";
            this.dtgvMedicine.RowHeadersWidth = 51;
            this.dtgvMedicine.Size = new System.Drawing.Size(1063, 185);
            this.dtgvMedicine.TabIndex = 20;
            this.dtgvMedicine.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvMedicine_CellMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select type";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(43, 98);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 17);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(900, 114);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 53);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(751, 114);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 53);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Create/Update";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(553, 130);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(160, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(349, 130);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 22);
            this.txtAmount.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(47, 130);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(275, 22);
            this.txtname.TabIndex = 11;
            // 
            // cmbSelectType
            // 
            this.cmbSelectType.FormattingEnabled = true;
            this.cmbSelectType.Location = new System.Drawing.Point(47, 29);
            this.cmbSelectType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSelectType.Name = "cmbSelectType";
            this.cmbSelectType.Size = new System.Drawing.Size(249, 24);
            this.cmbSelectType.TabIndex = 10;
            this.cmbSelectType.SelectedIndexChanged += new System.EventHandler(this.cmbSelectType_SelectedIndexChanged);
            // 
            // Medicine2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 456);
            this.Controls.Add(this.dtgvMedicine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cmbSelectType);
            this.Name = "Medicine2";
            this.Text = "Medicine2";
            this.Load += new System.EventHandler(this.Medicine2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMedicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cmbSelectType;
    }
}
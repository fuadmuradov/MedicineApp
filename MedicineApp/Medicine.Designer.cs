
namespace MedicineApp
{
    partial class Medicine
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
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.NumericUpDown();
            this.txtprice = new System.Windows.Forms.NumericUpDown();
            this.btnmedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(38, 88);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(247, 24);
            this.cmbtype.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(38, 184);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(247, 22);
            this.txtname.TabIndex = 1;
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(409, 88);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(138, 22);
            this.txtamount.TabIndex = 2;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(409, 185);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(138, 22);
            this.txtprice.TabIndex = 3;
            // 
            // btnmedicine
            // 
            this.btnmedicine.BackColor = System.Drawing.Color.LimeGreen;
            this.btnmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmedicine.Location = new System.Drawing.Point(44, 246);
            this.btnmedicine.Name = "btnmedicine";
            this.btnmedicine.Size = new System.Drawing.Size(503, 42);
            this.btnmedicine.TabIndex = 4;
            this.btnmedicine.Text = "Add Medicine";
            this.btnmedicine.UseVisualStyleBackColor = false;
            this.btnmedicine.Click += new System.EventHandler(this.btnmedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 180);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(503, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(602, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmedicine);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cmbtype);
            this.Name = "Medicine";
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.NumericUpDown txtamount;
        private System.Windows.Forms.NumericUpDown txtprice;
        private System.Windows.Forms.Button btnmedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
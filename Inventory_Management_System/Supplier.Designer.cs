namespace Inventory_Management_System
{
    partial class Supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierCompanyTxt = new System.Windows.Forms.TextBox();
            this.personNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone1Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone2Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ntnTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.supNameErrorLabel = new System.Windows.Forms.Label();
            this.contactPersonErrorLabel = new System.Windows.Forms.Label();
            this.phone1ErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.ntnTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.addressTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.phone2Txt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.phone1Txt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.personNameTxt);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.supplierCompanyTxt);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Controls.Add(this.supNameErrorLabel);
            this.leftPanel.Controls.Add(this.contactPersonErrorLabel);
            this.leftPanel.Controls.Add(this.phone1ErrorLabel);
            this.leftPanel.Controls.Add(this.addressErrorLabel);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1ErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactPersonErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.supNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label1, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierCompanyTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.personNameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone2Txt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.ntnTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier Name/Company";
            // 
            // supplierCompanyTxt
            // 
            this.supplierCompanyTxt.Location = new System.Drawing.Point(5, 87);
            this.supplierCompanyTxt.MaxLength = 100;
            this.supplierCompanyTxt.Name = "supplierCompanyTxt";
            this.supplierCompanyTxt.Size = new System.Drawing.Size(209, 23);
            this.supplierCompanyTxt.TabIndex = 2;
            // 
            // personNameTxt
            // 
            this.personNameTxt.Location = new System.Drawing.Point(5, 127);
            this.personNameTxt.MaxLength = 50;
            this.personNameTxt.Name = "personNameTxt";
            this.personNameTxt.Size = new System.Drawing.Size(209, 23);
            this.personNameTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact Person";
            // 
            // phone1Txt
            // 
            this.phone1Txt.Location = new System.Drawing.Point(5, 168);
            this.phone1Txt.MaxLength = 15;
            this.phone1Txt.Name = "phone1Txt";
            this.phone1Txt.Size = new System.Drawing.Size(209, 23);
            this.phone1Txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone 1";
            // 
            // phone2Txt
            // 
            this.phone2Txt.Location = new System.Drawing.Point(5, 209);
            this.phone2Txt.MaxLength = 15;
            this.phone2Txt.Name = "phone2Txt";
            this.phone2Txt.Size = new System.Drawing.Size(209, 23);
            this.phone2Txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(5, 252);
            this.addressTxt.MaxLength = 100;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(209, 23);
            this.addressTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // ntnTxt
            // 
            this.ntnTxt.Location = new System.Drawing.Point(5, 295);
            this.ntnTxt.MaxLength = 25;
            this.ntnTxt.Name = "ntnTxt";
            this.ntnTxt.Size = new System.Drawing.Size(209, 23);
            this.ntnTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "NTN #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(5, 339);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(209, 23);
            this.statusDD.TabIndex = 14;
            // 
            // supNameErrorLabel
            // 
            this.supNameErrorLabel.AutoSize = true;
            this.supNameErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.supNameErrorLabel.Location = new System.Drawing.Point(194, 66);
            this.supNameErrorLabel.Name = "supNameErrorLabel";
            this.supNameErrorLabel.Size = new System.Drawing.Size(24, 31);
            this.supNameErrorLabel.TabIndex = 15;
            this.supNameErrorLabel.Text = "*";
            this.supNameErrorLabel.Visible = false;
            // 
            // contactPersonErrorLabel
            // 
            this.contactPersonErrorLabel.AutoSize = true;
            this.contactPersonErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPersonErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.contactPersonErrorLabel.Location = new System.Drawing.Point(192, 105);
            this.contactPersonErrorLabel.Name = "contactPersonErrorLabel";
            this.contactPersonErrorLabel.Size = new System.Drawing.Size(24, 31);
            this.contactPersonErrorLabel.TabIndex = 16;
            this.contactPersonErrorLabel.Text = "*";
            this.contactPersonErrorLabel.Visible = false;
            // 
            // phone1ErrorLabel
            // 
            this.phone1ErrorLabel.AutoSize = true;
            this.phone1ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone1ErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.phone1ErrorLabel.Location = new System.Drawing.Point(193, 146);
            this.phone1ErrorLabel.Name = "phone1ErrorLabel";
            this.phone1ErrorLabel.Size = new System.Drawing.Size(24, 31);
            this.phone1ErrorLabel.TabIndex = 17;
            this.phone1ErrorLabel.Text = "*";
            this.phone1ErrorLabel.Visible = false;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.addressErrorLabel.Location = new System.Drawing.Point(192, 230);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(24, 31);
            this.addressErrorLabel.TabIndex = 18;
            this.addressErrorLabel.Text = "*";
            this.addressErrorLabel.Visible = false;
            this.addressErrorLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.statusErrorLabel.Location = new System.Drawing.Point(191, 316);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(24, 31);
            this.statusErrorLabel.TabIndex = 19;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            this.statusErrorLabel.Click += new System.EventHandler(this.statusErrorLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppIDGV,
            this.conNameGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
            this.statusGV});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(713, 429);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "suppID";
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // conNameGV
            // 
            this.conNameGV.HeaderText = "Company ";
            this.conNameGV.Name = "conNameGV";
            this.conNameGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Contact_Person";
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            dataGridViewCellStyle2.Format = "N2";
            this.phone2GV.DefaultCellStyle = dataGridViewCellStyle2;
            this.phone2GV.HeaderText = "Phone 2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox supplierCompanyTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone2Txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone1Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox personNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ntnTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label supNameErrorLabel;
        private System.Windows.Forms.Label contactPersonErrorLabel;
        private System.Windows.Forms.Label phone1ErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn conNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}
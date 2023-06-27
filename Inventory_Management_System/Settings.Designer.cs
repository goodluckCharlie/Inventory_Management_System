namespace Inventory_Management_System
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.DatabaseTxt = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.UserIDTxt = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.SaveButton);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Controls.Add(this.PasswordTxt);
            this.leftPanel.Controls.Add(this.Label5);
            this.leftPanel.Controls.Add(this.UserIDTxt);
            this.leftPanel.Controls.Add(this.Label4);
            this.leftPanel.Controls.Add(this.DatabaseTxt);
            this.leftPanel.Controls.Add(this.databaseLabel);
            this.leftPanel.Controls.Add(this.ServerTxt);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.leftPanel.Size = new System.Drawing.Size(220, 450);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label1, 0);
            this.leftPanel.Controls.SetChildIndex(this.ServerTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.DatabaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.Label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.UserIDTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.Label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.PasswordTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.SaveButton, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(580, 450);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(6, 127);
            this.ServerTxt.MaxLength = 50;
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(208, 23);
            this.ServerTxt.TabIndex = 2;
            this.ServerTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DatabaseTxt
            // 
            this.DatabaseTxt.Location = new System.Drawing.Point(6, 171);
            this.DatabaseTxt.MaxLength = 50;
            this.DatabaseTxt.Name = "DatabaseTxt";
            this.DatabaseTxt.Size = new System.Drawing.Size(208, 23);
            this.DatabaseTxt.TabIndex = 4;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseLabel.Location = new System.Drawing.Point(3, 153);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(58, 15);
            this.databaseLabel.TabIndex = 3;
            this.databaseLabel.Text = "Database";
            this.databaseLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserIDTxt
            // 
            this.UserIDTxt.Location = new System.Drawing.Point(6, 215);
            this.UserIDTxt.MaxLength = 30;
            this.UserIDTxt.Name = "UserIDTxt";
            this.UserIDTxt.Size = new System.Drawing.Size(208, 23);
            this.UserIDTxt.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(6, 197);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(46, 15);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "UserID";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(6, 259);
            this.PasswordTxt.MaxLength = 30;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(208, 23);
            this.PasswordTxt.TabIndex = 8;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(6, 241);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 15);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Password";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isCB.Location = new System.Drawing.Point(6, 289);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(135, 19);
            this.isCB.TabIndex = 9;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 2;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(6, 314);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(208, 33);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerTxt;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox UserIDTxt;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox DatabaseTxt;
        private System.Windows.Forms.Label databaseLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
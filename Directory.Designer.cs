namespace TelephoneDirektory
{
    partial class Directory
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
            this.GbxDirectory = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrbxProcedures = new System.Windows.Forms.GroupBox();
            this.MskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCareer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrbxUser = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblSurname = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.GbxDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrbxProcedures.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxDirectory
            // 
            this.GbxDirectory.Controls.Add(this.dataGridView1);
            this.GbxDirectory.Location = new System.Drawing.Point(3, 12);
            this.GbxDirectory.Name = "GbxDirectory";
            this.GbxDirectory.Size = new System.Drawing.Size(631, 160);
            this.GbxDirectory.TabIndex = 0;
            this.GbxDirectory.TabStop = false;
            this.GbxDirectory.Text = "Directory";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // GrbxProcedures
            // 
            this.GrbxProcedures.Controls.Add(this.txtCareer);
            this.GrbxProcedures.Controls.Add(this.label1);
            this.GrbxProcedures.Controls.Add(this.MskTelephone);
            this.GrbxProcedures.Controls.Add(this.TxtId);
            this.GrbxProcedures.Controls.Add(this.label10);
            this.GrbxProcedures.Controls.Add(this.button4);
            this.GrbxProcedures.Controls.Add(this.button1);
            this.GrbxProcedures.Controls.Add(this.button3);
            this.GrbxProcedures.Controls.Add(this.button2);
            this.GrbxProcedures.Controls.Add(this.TxtAdress);
            this.GrbxProcedures.Controls.Add(this.label6);
            this.GrbxProcedures.Controls.Add(this.TxtMail);
            this.GrbxProcedures.Controls.Add(this.label5);
            this.GrbxProcedures.Controls.Add(this.label4);
            this.GrbxProcedures.Controls.Add(this.TxtSurname);
            this.GrbxProcedures.Controls.Add(this.label3);
            this.GrbxProcedures.Controls.Add(this.txtName);
            this.GrbxProcedures.Controls.Add(this.label2);
            this.GrbxProcedures.Location = new System.Drawing.Point(5, 182);
            this.GrbxProcedures.Name = "GrbxProcedures";
            this.GrbxProcedures.Size = new System.Drawing.Size(337, 276);
            this.GrbxProcedures.TabIndex = 1;
            this.GrbxProcedures.TabStop = false;
            this.GrbxProcedures.Text = "Procedures";
            this.GrbxProcedures.Enter += new System.EventHandler(this.GrbxProcedures_Enter);
            // 
            // MskTelephone
            // 
            this.MskTelephone.BackColor = System.Drawing.SystemColors.Info;
            this.MskTelephone.Location = new System.Drawing.Point(111, 122);
            this.MskTelephone.Mask = "(999) 000-0000";
            this.MskTelephone.Name = "MskTelephone";
            this.MskTelephone.Size = new System.Drawing.Size(157, 22);
            this.MskTelephone.TabIndex = 4;
            // 
            // TxtId
            // 
            this.TxtId.BackColor = System.Drawing.SystemColors.Info;
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(109, 12);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(157, 22);
            this.TxtId.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Id:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Peru;
            this.button4.Location = new System.Drawing.Point(215, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Directory";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Location = new System.Drawing.Point(109, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Peru;
            this.button3.Location = new System.Drawing.Point(109, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Location = new System.Drawing.Point(215, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtAdress
            // 
            this.TxtAdress.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAdress.Location = new System.Drawing.Point(109, 177);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(157, 22);
            this.TxtAdress.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adress:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMail.Location = new System.Drawing.Point(109, 149);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(157, 22);
            this.TxtMail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telephone:";
            // 
            // TxtSurname
            // 
            this.TxtSurname.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSurname.Location = new System.Drawing.Point(109, 66);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(157, 22);
            this.TxtSurname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(109, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 22);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name:";
            // 
            // txtCareer
            // 
            this.txtCareer.BackColor = System.Drawing.SystemColors.Info;
            this.txtCareer.Location = new System.Drawing.Point(109, 94);
            this.txtCareer.Name = "txtCareer";
            this.txtCareer.Size = new System.Drawing.Size(157, 22);
            this.txtCareer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Career:";
            // 
            // GrbxUser
            // 
            this.GrbxUser.Location = new System.Drawing.Point(348, 182);
            this.GrbxUser.Name = "GrbxUser";
            this.GrbxUser.Size = new System.Drawing.Size(174, 132);
            this.GrbxUser.TabIndex = 2;
            this.GrbxUser.TabStop = false;
            this.GrbxUser.Text = "User";
            this.GrbxUser.Enter += new System.EventHandler(this.GrbxUser_Enter);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnExit.Location = new System.Drawing.Point(556, 451);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 37);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Location = new System.Drawing.Point(436, 397);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(30, 16);
            this.LblSurname.TabIndex = 11;
            this.LblSurname.Text = "Null";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(436, 363);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(30, 16);
            this.LblName.TabIndex = 10;
            this.LblName.Text = "Null";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(436, 335);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(30, 16);
            this.LblUsername.TabIndex = 9;
            this.LblUsername.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Surname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSalmon;
            this.button5.Location = new System.Drawing.Point(114, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 12;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Directory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(650, 497);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblSurname);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.GrbxUser);
            this.Controls.Add(this.GrbxProcedures);
            this.Controls.Add(this.GbxDirectory);
            this.Name = "Directory";
            this.Text = "Directory";
            this.Load += new System.EventHandler(this.Directory_Load);
            this.GbxDirectory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrbxProcedures.ResumeLayout(false);
            this.GrbxProcedures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxDirectory;
        private System.Windows.Forms.GroupBox GrbxProcedures;
        private System.Windows.Forms.GroupBox GrbxUser;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCareer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox MskTelephone;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
    }
}
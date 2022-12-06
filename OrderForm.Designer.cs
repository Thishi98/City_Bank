
namespace LotusFlora
{
    partial class OrderForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblBack = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radFuneral = new System.Windows.Forms.RadioButton();
            this.radParty = new System.Windows.Forms.RadioButton();
            this.radWedding = new System.Windows.Forms.RadioButton();
            this.radBirthday = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Findbtn = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtQtx = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.radOther);
            this.panel1.Controls.Add(this.radFuneral);
            this.panel1.Controls.Add(this.radParty);
            this.panel1.Controls.Add(this.radWedding);
            this.panel1.Controls.Add(this.radBirthday);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.Deletebtn);
            this.panel1.Controls.Add(this.Updatebtn);
            this.panel1.Controls.Add(this.Insertbtn);
            this.panel1.Controls.Add(this.Findbtn);
            this.panel1.Controls.Add(this.lblClear);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.txtQtx);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 808);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DarkMagenta;
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(325, 106);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(274, 28);
            this.dateTimePicker.TabIndex = 28;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(5, 110);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(70, 19);
            this.lblBack.TabIndex = 30;
            this.lblBack.Text = "<< Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(172, 581);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(224, 58);
            this.txtMsg.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Lavender;
            this.label10.Location = new System.Drawing.Point(40, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Any Message : ";
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(172, 464);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(147, 21);
            this.radOther.TabIndex = 27;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other Occations";
            this.radOther.UseVisualStyleBackColor = true;
            // 
            // radFuneral
            // 
            this.radFuneral.AutoSize = true;
            this.radFuneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFuneral.Location = new System.Drawing.Point(315, 437);
            this.radFuneral.Name = "radFuneral";
            this.radFuneral.Size = new System.Drawing.Size(84, 21);
            this.radFuneral.TabIndex = 26;
            this.radFuneral.TabStop = true;
            this.radFuneral.Text = "Funeral";
            this.radFuneral.UseVisualStyleBackColor = true;
            // 
            // radParty
            // 
            this.radParty.AutoSize = true;
            this.radParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radParty.Location = new System.Drawing.Point(172, 437);
            this.radParty.Name = "radParty";
            this.radParty.Size = new System.Drawing.Size(67, 21);
            this.radParty.TabIndex = 25;
            this.radParty.TabStop = true;
            this.radParty.Text = "Party";
            this.radParty.UseVisualStyleBackColor = true;
            // 
            // radWedding
            // 
            this.radWedding.AutoSize = true;
            this.radWedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWedding.Location = new System.Drawing.Point(315, 410);
            this.radWedding.Name = "radWedding";
            this.radWedding.Size = new System.Drawing.Size(92, 21);
            this.radWedding.TabIndex = 24;
            this.radWedding.TabStop = true;
            this.radWedding.Text = "Wedding";
            this.radWedding.UseVisualStyleBackColor = true;
            // 
            // radBirthday
            // 
            this.radBirthday.AutoSize = true;
            this.radBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBirthday.Location = new System.Drawing.Point(172, 410);
            this.radBirthday.Name = "radBirthday";
            this.radBirthday.Size = new System.Drawing.Size(89, 21);
            this.radBirthday.TabIndex = 23;
            this.radBirthday.TabStop = true;
            this.radBirthday.Text = "Birthday";
            this.radBirthday.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(458, 191);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(188, 23);
            this.lblMessage.TabIndex = 22;
            this.lblMessage.Text = "Upcomming Events : ";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Orchid;
            this.Deletebtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(325, 762);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 31);
            this.Deletebtn.TabIndex = 21;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Orchid;
            this.Updatebtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(178, 762);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 31);
            this.Updatebtn.TabIndex = 20;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Insertbtn
            // 
            this.Insertbtn.BackColor = System.Drawing.Color.Orchid;
            this.Insertbtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbtn.Location = new System.Drawing.Point(32, 762);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(75, 31);
            this.Insertbtn.TabIndex = 19;
            this.Insertbtn.Text = "Order";
            this.Insertbtn.UseVisualStyleBackColor = false;
            this.Insertbtn.Click += new System.EventHandler(this.Insertbtn_Click);
            // 
            // Findbtn
            // 
            this.Findbtn.BackColor = System.Drawing.Color.Orchid;
            this.Findbtn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findbtn.Location = new System.Drawing.Point(350, 151);
            this.Findbtn.Name = "Findbtn";
            this.Findbtn.Size = new System.Drawing.Size(75, 31);
            this.Findbtn.TabIndex = 18;
            this.Findbtn.Text = "Find";
            this.Findbtn.UseVisualStyleBackColor = false;
            this.Findbtn.Click += new System.EventHandler(this.Findbtn_Click);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.Location = new System.Drawing.Point(346, 721);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(77, 19);
            this.lblClear.TabIndex = 17;
            this.lblClear.Text = "Clear All";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Location = new System.Drawing.Point(438, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 695);
            this.panel3.TabIndex = 16;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(454, 230);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(684, 475);
            this.dgv.TabIndex = 15;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // txtQtx
            // 
            this.txtQtx.Location = new System.Drawing.Point(172, 673);
            this.txtQtx.Name = "txtQtx";
            this.txtQtx.Size = new System.Drawing.Size(118, 22);
            this.txtQtx.TabIndex = 13;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(171, 514);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(224, 22);
            this.txtType.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(172, 301);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(224, 65);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 219);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 40);
            this.txtName.TabIndex = 9;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(172, 155);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(164, 22);
            this.txtNo.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(3, 676);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ordered Quantity : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(42, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flower Types : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lavender;
            this.label5.Location = new System.Drawing.Point(68, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Function : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(66, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(83, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(42, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.lblMin);
            this.panel2.Controls.Add(this.lblClose);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 107);
            this.panel2.TabIndex = 0;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Black;
            this.lblMin.Location = new System.Drawing.Point(1102, -5);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 26);
            this.lblMin.TabIndex = 26;
            this.lblMin.Text = "_";
            this.lblMin.Click += new System.EventHandler(this.label7_Click);
            this.lblMin.MouseEnter += new System.EventHandler(this.lblMin_MouseEnter);
            this.lblMin.MouseLeave += new System.EventHandler(this.lblMin_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(1122, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 25);
            this.lblClose.TabIndex = 25;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label16.Location = new System.Drawing.Point(494, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 23);
            this.label16.TabIndex = 27;
            this.label16.Text = "*Order Now*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LotusFlora.Properties.Resources.lotus_copy;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 50);
            this.label1.TabIndex = 26;
            this.label1.Text = "Black Lotus";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 805);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Findbtn;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtQtx;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radFuneral;
        private System.Windows.Forms.RadioButton radParty;
        private System.Windows.Forms.RadioButton radWedding;
        private System.Windows.Forms.RadioButton radBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBack;
    }
}
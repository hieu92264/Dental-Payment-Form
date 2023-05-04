namespace Dental_Payment_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt_Name = new TextBox();
            CB_Cao_voi = new CheckBox();
            CB_Tay_trang = new CheckBox();
            CB_Chup_hinh_rang = new CheckBox();
            numericUpDown = new NumericUpDown();
            txt_Total = new TextBox();
            BTN_Exit = new Button();
            BTN_Run = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(97, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 19);
            label1.TabIndex = 0;
            label1.Text = "Dental Payment Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 255);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Trám răng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 314);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 6;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(241, 125);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 7;
            label8.Text = "$100.000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(241, 175);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 8;
            label9.Text = "$1.200.000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 221);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 9;
            label10.Text = "$200.000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(241, 255);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 10;
            label11.Text = "$80.000/cái";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(144, 60);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(160, 23);
            txt_Name.TabIndex = 11;
            txt_Name.TextChanged += txt_Name_TextChanged;
            txt_Name.KeyPress += txt_Name_KeyPress;
            // 
            // CB_Cao_voi
            // 
            CB_Cao_voi.AutoSize = true;
            CB_Cao_voi.Location = new Point(35, 124);
            CB_Cao_voi.Name = "CB_Cao_voi";
            CB_Cao_voi.Size = new Size(66, 19);
            CB_Cao_voi.TabIndex = 12;
            CB_Cao_voi.Text = "Cạo vôi";
            CB_Cao_voi.UseVisualStyleBackColor = true;
            CB_Cao_voi.CheckedChanged += CB_Cao_voi_CheckedChanged;
            // 
            // CB_Tay_trang
            // 
            CB_Tay_trang.AutoSize = true;
            CB_Tay_trang.Location = new Point(35, 174);
            CB_Tay_trang.Name = "CB_Tay_trang";
            CB_Tay_trang.Size = new Size(75, 19);
            CB_Tay_trang.TabIndex = 13;
            CB_Tay_trang.Text = "Tẩy trắng";
            CB_Tay_trang.UseVisualStyleBackColor = true;
            CB_Tay_trang.CheckedChanged += CB_Tay_trang_CheckedChanged;
            // 
            // CB_Chup_hinh_rang
            // 
            CB_Chup_hinh_rang.AutoSize = true;
            CB_Chup_hinh_rang.Location = new Point(35, 217);
            CB_Chup_hinh_rang.Name = "CB_Chup_hinh_rang";
            CB_Chup_hinh_rang.Size = new Size(109, 19);
            CB_Chup_hinh_rang.TabIndex = 14;
            CB_Chup_hinh_rang.Text = "Chụp hình răng";
            CB_Chup_hinh_rang.UseVisualStyleBackColor = true;
            CB_Chup_hinh_rang.CheckedChanged += CB_Chup_hinh_rang_CheckedChanged;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(101, 247);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(52, 23);
            numericUpDown.TabIndex = 15;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // txt_Total
            // 
            txt_Total.Location = new Point(202, 306);
            txt_Total.Name = "txt_Total";
            txt_Total.ReadOnly = true;
            txt_Total.Size = new Size(118, 23);
            txt_Total.TabIndex = 16;
            // 
            // BTN_Exit
            // 
            BTN_Exit.Location = new Point(50, 366);
            BTN_Exit.Name = "BTN_Exit";
            BTN_Exit.Size = new Size(75, 23);
            BTN_Exit.TabIndex = 17;
            BTN_Exit.Text = "Thoát";
            BTN_Exit.UseVisualStyleBackColor = true;
            BTN_Exit.Click += BTN_Exit_Click;
            // 
            // BTN_Run
            // 
            BTN_Run.Location = new Point(241, 366);
            BTN_Run.Name = "BTN_Run";
            BTN_Run.Size = new Size(75, 23);
            BTN_Run.TabIndex = 18;
            BTN_Run.Text = "Tính tiền";
            BTN_Run.UseVisualStyleBackColor = true;
            BTN_Run.Click += BTN_Run_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(BTN_Run);
            Controls.Add(BTN_Exit);
            Controls.Add(txt_Total);
            Controls.Add(numericUpDown);
            Controls.Add(CB_Chup_hinh_rang);
            Controls.Add(CB_Tay_trang);
            Controls.Add(CB_Cao_voi);
            Controls.Add(txt_Name);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dental Payment Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txt_Name;
        private CheckBox CB_Cao_voi;
        private CheckBox CB_Tay_trang;
        private CheckBox CB_Chup_hinh_rang;
        private NumericUpDown numericUpDown;
        private TextBox txt_Total;
        private Button BTN_Exit;
        private Button BTN_Run;
    }
}
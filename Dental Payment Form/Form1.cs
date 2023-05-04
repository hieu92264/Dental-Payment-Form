namespace Dental_Payment_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_Cao_voi.Enabled = false;
            CB_Chup_hinh_rang.Enabled = false;
            CB_Tay_trang.Enabled = false;
            BTN_Run.Enabled = false;
            numericUpDown.Enabled = false;

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Name.Text != "")
            {
                CB_Cao_voi.Enabled = true;
                CB_Chup_hinh_rang.Enabled = true;
                CB_Tay_trang.Enabled = true;
                numericUpDown.Enabled = true;
            }
            else
            {
                CB_Cao_voi.Enabled = false;
                CB_Chup_hinh_rang.Enabled = false;
                CB_Tay_trang.Enabled = false;
            }
        }

        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập sai tên!");
            }
        }

        private void BTN_Run_Click(object sender, EventArgs e)
        {
            try
            {
                int s = 0;
                if (CB_Cao_voi.Checked)
                {
                    s += 100000;
                }
                if (CB_Tay_trang.Checked)
                {
                    s += 1200000;
                }
                if (CB_Chup_hinh_rang.Checked)
                {
                    s += 200000;
                }
                if (numericUpDown.Value != 0)
                {
                    int n = Convert.ToInt32(numericUpDown.Value);
                    s += n * 80000;
                }
                txt_Total.Text = s.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Application.Exit();
        }

        private void CB_Cao_voi_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Run.Enabled = true;
        }

        private void CB_Tay_trang_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Run.Enabled = true;
        }

        private void CB_Chup_hinh_rang_CheckedChanged(object sender, EventArgs e)
        {
            BTN_Run.Enabled = true;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BTN_Run.Enabled = true;
        }
    }
}
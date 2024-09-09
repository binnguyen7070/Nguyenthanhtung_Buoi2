namespace Nguyenthanhtung_Buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool ktraSNT(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private void txtn_TextChanged(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txtn.Text != string.Empty)
            {
                if (ktraSNT(int.Parse(txtn.Text)))
                {
                    txt_kq.Text = "Là SNT";
                }
                else
                {
                    txt_kq.Text = "Không là SNT";
                }
                for (int i = 2; i < int.Parse(txtn.Text); i++)
                    {
                        if (ktraSNT((int)i))
                        {
                            kq += " " + i;
                        }
                        txt_sntN.Text = kq;
                    }
                }
            }
        }
    }
                


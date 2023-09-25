namespace WinFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru_no = 0, dogru = 0, yanlis = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            lbl_Cvp_ver.Text = BtnA.Text;
            if (lblCvp.Text == lbl_Cvp_ver.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;

            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soru_no++;
            lblSoru.Text = soru_no.ToString();

            if (soru_no == 1)
            {
                richTextBox1.Text = "cumhuriyet ilan yýlý ?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                lblCvp.Text = "1923";
            }

            if (soru_no == 2)
            {
                richTextBox1.Text = "Hangi þehir egede bulunmaz?";
                BtnA.Text = "Ýzmir";
                BtnB.Text = "Denizli";
                BtnC.Text = "Isparta";
                BtnD.Text = "Kütahya";
                lblCvp.Text = "Isparta";
            }
            if (soru_no == 3)
            {
                richTextBox1.Text = "1984 kitabýn yazarý kimdir?";
                BtnA.Text = "G.owell";
                BtnB.Text = "murat B.";
                BtnC.Text = "Serpil S.";
                BtnD.Text = "Ahmet Z.";
                lblCvp.Text = "G.owell.";
                BtnSonraki.Text = "Sonuç";
            }
            if (soru_no == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("DOÐRU: " + dogru + "\n" + "YANLIÞ: " + yanlis);
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            lbl_Cvp_ver.Text = BtnB.Text;
            if (lblCvp.Text == lbl_Cvp_ver.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            lbl_Cvp_ver.Text = BtnC.Text;
            if (lblCvp.Text == lbl_Cvp_ver.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            lbl_Cvp_ver.Text = BtnD.Text;
            if (lblCvp.Text == lbl_Cvp_ver.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            
        }
    }
}
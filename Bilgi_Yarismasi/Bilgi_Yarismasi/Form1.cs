namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;



            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
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

        private void btnD_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
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

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if(label4.Text == label5.Text)
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

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblSoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                btnA.Text = "1920";
                btnB.Text = "1923";
                btnC.Text = "1919";
                btnD.Text = "1924";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesinde bulunmaz?";
                btnA.Text = "Ýzmir";
                btnB.Text = "Balýkesir";
                btnC.Text = "Aydýn";
                btnD.Text = "Manisa";
                label4.Text = "Balýkesir";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuþlar hangi yazara aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atilla Ýlhan";
                btnD.Text = "Reþat Nuri";
                label4.Text = "Sait Faik";
            }

        }
    }
}
namespace Sinema_Bufe_Satıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int misir, bilet, su, cay,toplam;
            misir = Convert.ToUInt16(TxtMisir.Text);
            bilet = Convert.ToUInt16(TxtBilet.Text);
            su = Convert.ToUInt16(TxtSu.Text);
            cay = Convert.ToUInt16(TxtCay.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            LblToplam.Text=toplam.
                ToString();
            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
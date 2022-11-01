namespace Ucus_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox3.Text + "-" + comboBox4.Text + "Tarih:" + dateTimePicker2.Text + "Saat:" + maskedTextBox4.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
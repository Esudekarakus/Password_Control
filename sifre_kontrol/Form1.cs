namespace sifre_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string sifreKontrol;
        int karaktersy;

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;
            karaktersy = sifre.Length;
            int kalanKaraktersy = 50 - karaktersy;

            label2.Text = kalanKaraktersy.ToString();
            bool ozelKarakterVarmi = false;
            bool sayiVarmi = false;

            foreach (char s in sifre)
            {
                if (!char.IsLetterOrDigit(s))
                {
                    //özel karakterse false gelecek
                    ozelKarakterVarmi = true;


                }
                else if (char.IsDigit(s))
                {
                    sayiVarmi = true;
                }

            }

            if (karaktersy < 6)
            {
                sifreKontrol = "zayýf";
                label1.Text = sifreKontrol;
                label1.ForeColor= Color.Red;
                //


            }

            else if (ozelKarakterVarmi == true || sayiVarmi == true)
            {

                sifreKontrol = "orta";
                label1.Text = sifreKontrol;
                label1.ForeColor = Color.Green;
            }

            if (karaktersy > 6 && ozelKarakterVarmi == true && sayiVarmi == true)

            {

                sifreKontrol = "Güçlü parola";
                label1.Text = sifreKontrol;
                label1.ForeColor = Color.Blue;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (karaktersy < 6)
            {
                MessageBox.Show("Þifre kabul edilmedi!");
            }
            else
            {
                MessageBox.Show("Þifre kabul edildi.");
            }

            txtSifre.Clear();



        }

    }
}

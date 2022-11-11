namespace _3_harjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Laskutoimitukset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            //t‰ss‰ joudumme tekem‰‰n lukumuunnoksen tekstist‰ liukuluvuksi komennolla float.Parse(luku)
            float luku1 = float.Parse(LukuYksiTB.Text); 
            float luku2 = float.Parse(LukuKaksiTB.Text);
            float vastaus = 0;
            string merkki = LaskutoimitusCB.Text;

            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2; // t‰ss‰ double, koska voi tulla murtoluku
                    break;
                default:
                    Console.WriteLine("Tapahtui virhe!");
                    break;
            }

            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true; // muista ottaa n‰kyviin!!!

        }
    }
}
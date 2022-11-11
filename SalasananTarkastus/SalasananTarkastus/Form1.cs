namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Ku1lta")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheViestiLB.Visible = true;
            }
        }
    }
}
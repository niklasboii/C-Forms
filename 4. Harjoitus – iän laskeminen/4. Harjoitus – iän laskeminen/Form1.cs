namespace _4._Harjoitus___iän_laskeminen
{
    public partial class IkaForm : Form
    {
        public IkaForm()
        {
            InitializeComponent();
        }

        private void LaskeIkaBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Ceiling(erotus / 365.35) + " vuotta";
            KuukausinaLB.Text = Math.Ceiling(erotus * 12 / 365.35) + " kuukautta";
            PaivinaLB.Text = erotus + " päivää";
            TunteinaLB.Text = (erotus * 24) + " tuntia";
            MinuutteinaLB.Text = (erotus * 24 * 60) + " minuuttia";
            SekuntteinaLB.Text = (erotus * 24 * 60 * 60) + " sekuntteina";
            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekuntteinaLB.Visible = true;
        }
    }
}
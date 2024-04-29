namespace kundenverwaltung
{
    public partial class Form1 : Form
    {
        public struct TKunde
        {
            public string anrede;
            public string name;
            public string vorname;
            public int alter;
            public double umsatz;
        }

        public TKunde kunde1;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            kunde1.anrede = textBoxAnrede.Text;
            kunde1.name = textBoxName.Text;
            kunde1.vorname = textBoxVorname.Text;
            kunde1.alter = (int)Convert.ToInt64(textBoxAlter.Text);
            kunde1.umsatz = (double)Convert.ToDouble(textBoxUmsatz.Text);

            textBoxAnrede.Text = "";
            textBoxName.Text = "";
            textBoxVorname.Text = "";
            textBoxAlter.Text = "";
            textBoxUmsatz.Text = "";
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            textBoxAnrede.Text = kunde1.anrede;
            textBoxName.Text = kunde1.name;
            textBoxVorname.Text = kunde1.vorname;
            textBoxAlter.Text = kunde1.alter.ToString();
            textBoxUmsatz.Text = kunde1.umsatz.ToString();
        }
    }
}

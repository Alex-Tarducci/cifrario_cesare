namespace cifrario_cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string testoOriginale = txt_stringa1.Text;
            int chiave = 0;
            string testorisultato = "";
            chiave = chiave % 26;

            if (!int.TryParse(txt_chiave.Text, out chiave))
            {
                MessageBox.Show("Per favore, inserisci un numero valido nella casella della chiave e della stringa!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                for (int i = 0; i < txt_stringa1.Text.Length; i++)
                {
                    char carattere = testoOriginale[i];

                    if (carattere >= 'A' && carattere <= 'Z')
                    {
                        char nuovocarattere = (char)(carattere + chiave);

                        if (nuovocarattere > 'Z')
                        {
                            nuovocarattere = (char)(nuovocarattere - 26);
                        }

                        if (nuovocarattere < 'A')
                        {
                            nuovocarattere = (char)(nuovocarattere + 26);
                        }

                        testorisultato = testorisultato + nuovocarattere;
                    }

                    else if (carattere >= 'a' && carattere <= 'z')
                    {
                        char nuovocarattere = (char)(carattere + chiave);

                        if (nuovocarattere > 'z')
                        {
                            nuovocarattere = (char)(nuovocarattere - 26);
                        }

                        if (nuovocarattere < 'a')
                        {
                            nuovocarattere = (char)(nuovocarattere + 26);
                        }

                        testorisultato = testorisultato + nuovocarattere;
                    }

                    else
                    {
                        testorisultato = testorisultato + carattere;
                    }
                }

                lbl_risultato1.Text = "RISULTATO: " + testorisultato;


            }
        }

        private void btn_cripta2_Click(object sender, EventArgs e)
        {
            string testoOriginale = txt_stringa2.Text;
            int chiave = 0;
            string testorisultato = "";
            chiave = chiave % 26;

            if (!int.TryParse(txt_chiave.Text, out chiave))
            {
                MessageBox.Show("Per favore, inserisci un numero valido nella casella della chiave e della stringa!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                for (int i = 0; i < txt_stringa2.Text.Length; i++)
                {
                    char carattere = testoOriginale[i];

                    if (carattere >= 'A' && carattere <= 'Z')
                    {
                        char nuovocarattere = (char)(carattere - chiave);

                        if (nuovocarattere > 'Z')
                        {
                            nuovocarattere = (char)(nuovocarattere - 26);
                        }

                        if (nuovocarattere < 'A')
                        {
                            nuovocarattere = (char)(nuovocarattere + 26);
                        }

                        testorisultato = testorisultato + nuovocarattere;
                    }

                    else if (carattere >= 'a' && carattere <= 'z')
                    {
                        char nuovocarattere = (char)(carattere - chiave);

                        if (nuovocarattere > 'z')
                        {
                            nuovocarattere = (char)(nuovocarattere - 26);
                        }

                        if (nuovocarattere < 'a')
                        {
                            nuovocarattere = (char)(nuovocarattere + 26);
                        }

                        testorisultato = testorisultato + nuovocarattere;
                    }

                    else
                    {
                        testorisultato = testorisultato + carattere;
                    }
                }

                lbl_risultato2.Text = "RISULTATO: " + testorisultato;
            }
        }
    }
}

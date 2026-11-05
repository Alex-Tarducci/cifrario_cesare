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
            int chiave = Convert.ToInt32(txt_chiave.Text);
            string testorisultato = "";
            chiave = chiave % 26;
            
            if (  string.IsNullOrEmpty(testoOriginale))
            {
                MessageBox.Show("il carattere non è stato inserito");
            }

            else
            {
                for (int i = 0; i < txt_stringa1.Text.Length; i++)
                {
                    char carattere = testoOriginale[i];

                    if ( carattere >= 'A' && carattere <= 'Z')
                    {
                        char nuovocarattere = (char)(carattere + chiave);

                        if(nuovocarattere > 'Z')
                        {
                            nuovocarattere = (char)(nuovocarattere - 26);
                        }

                        if(nuovocarattere < 'A')
                        {
                            nuovocarattere = (char)(nuovocarattere + 26);
                        }

                        testorisultato = testorisultato + nuovocarattere;
                    }

                    
                }


            }
        }
    }
}

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
            string testooriginale = txt_stringa1.Text;
            int chiave = int.Parse(txt_chiave.Text);
            string testorisultato = "";


            if (!int.TryParse(txt_chiave.Text, out chiave))
            {
                MessageBox.Show("Per favore, inserisci un numero valido nella casella della chiave e della stringa!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                chiave = (chiave % 26 + 26) % 26;

                string testoCifrato = "";


                for (int i = 0; i < testooriginale.Length; i++)
                {
                    char c = testooriginale[i];


                    if (c >= 'A' && c <= 'Z')
                    {
                        char cifrato = (char)('A' + (c - 'A' + chiave) % 26);
                        testoCifrato += cifrato;
                    }

                    else if (c >= 'a' && c <= 'z')
                    {
                        char cifrato = (char)('a' + (c - 'a' + chiave) % 26);
                        testoCifrato += cifrato;
                    }

                    else
                    {
                        testoCifrato += c;
                    }
                }


                lbl_risultato1.Text = testoCifrato;
            }

           
           
        }


    
        

        private void btn_cripta2_Click(object sender, EventArgs e)
        {
            string testooriginale = txt_stringa2.Text;
            int chiave = 0;
            
            chiave = chiave % 26;

            if (!int.TryParse(txt_chiave.Text, out chiave))
            {
                MessageBox.Show("Per favore, inserisci un numero valido nella casella della chiave e della stringa!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                chiave = (chiave % 26 + 26) % 26;

                string testoCifrato = "";


                for (int i = 0; i < testooriginale.Length; i++)
                {
                    char c = testooriginale[i];


                    if (c >= 'A' && c <= 'Z')
                    {
                        char cifrato = (char)('A' + (c + 'A' + chiave) % 26);
                        testoCifrato += cifrato;
                    }

                    else if (c >= 'a' && c <= 'z')
                    {
                        char cifrato = (char)('a' + (c + 'a' + chiave) % 26);
                        testoCifrato += cifrato;
                    }

                    else
                    {
                        testoCifrato += c;
                    }
                }


                lbl_risultato2.Text = testoCifrato;
            }
        }

       
    }
}

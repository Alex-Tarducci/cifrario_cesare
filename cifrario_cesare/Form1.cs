namespace cifrario_cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cripta_Click(object sender, EventArgs e)
        {
            string testooriginale = txt_stringa1.Text;

            if (string.IsNullOrWhiteSpace(txt_stringa1.Text))
            {
                MessageBox.Show("La casella della stringa non può essere vuota!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_stringa1.Focus();
                return;
            }

            if (!int.TryParse(txt_chiave.Text, out int chiave))
            {
                MessageBox.Show("Per favore, inserisci una chiave!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_chiave.Focus();
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


    
        

        private void btn_decripta_Click(object sender, EventArgs e)
        {
            string testooriginale = txt_stringa2.Text;

            if (string.IsNullOrWhiteSpace(txt_stringa2.Text))
            {
               MessageBox.Show("La casella della stringa non può essere vuota!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txt_stringa2.Focus();
              return;
            }

            if (!int.TryParse(txt_chiave.Text, out int chiave))
            {
               MessageBox.Show("Per favore, inserisci una chiave!", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txt_chiave.Focus();
             return;
            }
            else
            {
                chiave = (-chiave % 26 + 26) % 26;

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


                lbl_risultato2.Text = testoCifrato;
            }
        }

       
    }
}

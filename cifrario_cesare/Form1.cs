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
            string carattere = txt_stringa1.Text;
            int chiave = Convert.ToInt32
            string risultato = "";
            
            if (  string.IsNullOrEmpty(carattere))
            {
                MessageBox.Show("il carattere non è stato inserito");
            }

            else
            {
                for (int i = 0; i < txt_stringa1.Text.Length; i++)
                { 

                }


            }   
        }
    }
}

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
            string carattere = txt_n1.Text;
            
            if (  string.IsNullOrEmpty(carattere))
            {
                MessageBox.Show("il carattere non è stato inserito");
            }

            else
            {
                for (int i = 0; i < txt_n1.Text.Length; i++)
                { 

                }


            }   
        }
    }
}

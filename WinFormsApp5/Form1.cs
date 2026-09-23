namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            bool duzdur = true;

            int at = email.IndexOf('@');
            int sonAt = email.LastIndexOf('@');
            int noqte = email.LastIndexOf('.');

            if (email.Length < 6)
                duzdur = false;

            if (email.Contains(" "))
                duzdur = false;

            if (at == -1)
                duzdur = false;

            if (at != sonAt)
                duzdur = false;

            if (at <= 0)
                duzdur = false;

            if (noqte <= at + 1)
                duzdur = false;

            if (noqte >= email.Length - 2)
                duzdur = false;

            if (duzdur)
                MessageBox.Show("Email düzgündür");
            else
                MessageBox.Show("Email düzgün deyil");
        }
    }
}
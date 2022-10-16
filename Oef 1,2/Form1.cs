namespace Oef_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsEveritingDigit(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }

        Stapel<int> integers = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();
        Stapel<Persoon> personen = new Stapel<Persoon>();



        private void label1_Click(object sender, EventArgs e)
        {
            if (IsEveritingDigit(textbox1.Text))
            {
              integers.OpDeStapel(int.Parse(textbox1.Text));

            }
            else
            {
                MessageBox.Show("enkel integers toegelaten ! ");
                textbox1.Text = null;
            }

            textbox1.Text = null;
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            if (integers.ToString() != string.Empty)
            {
                integers.vanDeStapel();
            }
            else
            {
                MessageBox.Show(" de stapel is al leeg ! ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
 



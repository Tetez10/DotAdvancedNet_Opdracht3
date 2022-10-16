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


        private void button1_Click(object sender, EventArgs e)
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
            integers.StapelLeegMaken();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            integerlist.Text =  "integers: " +  integers.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (integers.IsAanwezigOpStapel(int.Parse(textbox1.Text)))
            {

                MessageBox.Show(textbox1.Text + " " + "is aanwezig op de stapel van integers");
            }
            else
            {
                MessageBox.Show("sorry maar " + textbox1.Text + " bestaat niet op de stapel");
            }

            textbox1.Text = null;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" oude lijst : " + integers.ToString() + "\n new list  : " + " " +
             String.Join(",", integers.lijstCopy()));


        }

        private void textbox7_Click(object sender, EventArgs e)
        {
            strings.OpDeStapel(textbox2.Text);

            textbox2.Text = null;

        }

        private void textbox8_Click(object sender, EventArgs e)
        {
            if (strings.ToString() != string.Empty)
            {
                strings.vanDeStapel();
            }
            else
            {
                MessageBox.Show("de stapel is al leeg !");
            }


        }

        private void textbox9_Click(object sender, EventArgs e)
        {
            strings.StapelLeegMaken();
        }

        private void textbox10_Click(object sender, EventArgs e)
        {
            stringlist.Text =  "strings : " +  strings.ToString();
        }

        private void textbox11_Click(object sender, EventArgs e)
        {
            if (strings.IsAanwezigOpStapel(textbox2.Text))
            {
                MessageBox.Show(textbox2.Text + " " + "is aanwezig op de stapel van strings");
            }
            else
            {
                MessageBox.Show("sorry  " + textbox2.Text + "  :  bestaat niet op de stapel");
            }

            textbox2.Text = null;

        }

        private void textbox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strings.ToString() + "\n  new list is  : " + " " +
              String.Join(",", strings.lijstCopy()));
        }

        private void textbox13_Click(object sender, EventArgs e)
        {
            if (textbox3.Text == string.Empty || textbox4.Text == string.Empty)
            {

                MessageBox.Show("beide velden moeten ingevuld worden ! ");

            }
            else if (IsEveritingDigit(textbox4.Text) == false)
            {
                MessageBox.Show(" leeftijd moet enkel getallen bevatten");
            }

            else
            {
                personen.OpDeStapel(new Persoon(textbox3.Text, int.Parse(textbox4.Text)));
            }

            textbox3.Text = null;
            textbox4.Text = null;

        }

        private void textbox14_Click(object sender, EventArgs e)
        {
            if (personen.ToString() != string.Empty)
            {
                personen.vanDeStapel();
            }
            else
            {
                MessageBox.Show("stapel is leeg  !");
            }
        }

        private void textbox15_Click(object sender, EventArgs e)
        {
            personen.StapelLeegMaken();
        }

        private void textbox16_Click(object sender, EventArgs e)
        {
            personenlist.Text = "personen : " +  personen.ToString();
        }

        private void textbox17_Click(object sender, EventArgs e)
        {
            if (personen.IsAanwezigOpStapel(new Persoon(textbox3.Text, int.Parse(textbox4.Text))))
            {
                MessageBox.Show(" persoon : " + " " + textbox3.Text + " en met leeftijd : " + " " + textbox4.Text + " " + "is aanwezig in de lijst van personen");
            }
            else
            {
                MessageBox.Show(" persoon  : " + " "+ textbox3.Text + " " + "bestaat niet ");
            }
        }

        private void textbox18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" oude lijst  : " + personen.ToString() + "\n new list : " + " " +
                String.Join(":", personen.lijstCopy()));
        }

        
    }
}

 



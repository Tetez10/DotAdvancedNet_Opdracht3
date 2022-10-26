namespace Oef_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Stapel<int> integers = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();
        Stapel<Auto> Autos = new Stapel<Auto>();


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

        


        private void button1_Click(object sender, EventArgs e)
        {
            if (IsEveritingDigit(textbox1.Text))
            {
                integers.AddStapel(int.Parse(textbox1.Text));

            }
            else
            {
                MessageBox.Show("enkel integers aub ");
                textbox1.Text = null;
            }

            textbox1.Text = null;

        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (integers.ToString() != string.Empty)
            {
                integers.RemoveStapel();
            }
            else
            {
                MessageBox.Show(" de stapel is  leeg.  ");
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
            if (integers.IsOpStapel(int.Parse(textbox1.Text)))
            {

                MessageBox.Show(textbox1.Text + "is aanwezig bij integers");
            }
            else
            {
                MessageBox.Show(textbox1.Text + " bestaat niet");
            }

            textbox1.Text = null;


        }



        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" oude lijst : " + integers.ToString() + " nieuwe lijst  : " + " " +
             String.Join(",", integers.lijstCopy()));


        }




        private void textbox7_Click(object sender, EventArgs e)
        {
            strings.AddStapel(textbox2.Text);

            textbox2.Text = null;

        }




        private void textbox8_Click(object sender, EventArgs e)
        {
            if (strings.ToString() != string.Empty)
            {
                strings.RemoveStapel();
            }
            else
            {
                MessageBox.Show("de stapel is leeg");
            }


        }

        



        private void textbox10_Click(object sender, EventArgs e)
        {
            stringlist.Text =  "strings : " +  strings.ToString();
        }


        private void textbox9_Click(object sender, EventArgs e)
        {
            strings.StapelLeegMaken();
        }





        private void textbox11_Click(object sender, EventArgs e)
        {
            if (strings.IsOpStapel(textbox2.Text))
            {
                MessageBox.Show(textbox2.Text + " " + "is aanwezig op de stapel strings");
            }
            else
            {
                MessageBox.Show(textbox2.Text + "  :  bestaat niet in de stapel");
            }

            textbox2.Text = null;

        }





      
        private void textbox13_Click(object sender, EventArgs e)
        {
            if (textbox3.Text == string.Empty || textbox4.Text == string.Empty)
            {

                MessageBox.Show("alle velden moeten gevuld");

            }
            else if (IsEveritingDigit(textbox4.Text) == false)
            {
                MessageBox.Show(" leeftijd in cijfers aub ");
            }

            else
            {
                Autos.AddStapel(new Auto(textbox3.Text, int.Parse(textbox4.Text)));
            }

            textbox3.Text = null;
            textbox4.Text = null;

        }




        private void textbox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strings.ToString() + "\n  niewe lijst is : " + " " +
              String.Join(",", strings.lijstCopy()));
        }


        private void textbox15_Click(object sender, EventArgs e)
        {
            Autos.StapelLeegMaken();
        }

        private void textbox16_Click(object sender, EventArgs e)
        {
            personenlist.Text = "Autos : " +  Autos.ToString();
        }


        private void textbox14_Click(object sender, EventArgs e)
        {
            if (Autos.ToString() != string.Empty)
            {
                Autos.RemoveStapel();
            }
            else
            {
                MessageBox.Show("stapel is leeg");
            }
        }




        private void textbox17_Click(object sender, EventArgs e)
        {
            if (Autos.IsOpStapel(new Auto(textbox3.Text, int.Parse(textbox4.Text))))
            {
                MessageBox.Show(" auto : " + " " + textbox3.Text + " OpbouwJaar : " + " " + textbox4.Text + " " + "is aanwezig in de lijst van autos");
            }
            else
            {
                MessageBox.Show(" auto  : " + " "+ textbox3.Text + " " + "bestaat niet ");
            }
        }




        private void textbox18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" oude lijst  : " + Autos.ToString() + " nieuwe lijst : " + " " +
                String.Join(":", Autos.lijstCopy()));
        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

 



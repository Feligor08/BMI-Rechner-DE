namespace Max_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kg, m, m2;
            kg = Convert.ToDouble((textBoxKg.Text));
            m = Convert.ToDouble((textBoxM.Text));
            m2 = Math.Pow(m, 2);

            if (comboBox1.SelectedIndex == 1)
            {
                double wert = kg / m2;

                // Bestimmung der Klassifikation anhand des Wertes
                string kategorie = "";

                if (wert >= 10 && wert < 19)
                {
                    kategorie = "Untergewichtig";
                }
                else if (wert >= 19 && wert <= 24)
                {
                    kategorie = "Normal";
                }
                else if (wert >= 26 && wert <= 29)
                {
                    kategorie = "Übergewichtig";
                }
                else if (wert >= 31 && wert <= 39)
                {
                    kategorie = "Fettleibig";
                }
                else if (wert > 40)
                {
                    kategorie = "Extrem fettleibig";
                }

                // Ergebnis in einem Label anzeigen
                labelErgebnis.Text = $"Wert: {wert:F2}\n // Kategorie: {kategorie}";
            }

            else 
            {
                double wert = kg / m2;

                // Bestimmung der Klassifikation anhand des Wertes
                string kategorie = "";

                if (wert >= 10 && wert < 19)
                {
                    kategorie = "Untergewichtig";
                }
                else if (wert >= 20 && wert <= 25)
                {
                    kategorie = "Normal";
                }
                else if (wert >= 26 && wert <= 31)
                {
                    kategorie = "Übergewichtig";
                }
                else if (wert >= 32 && wert <= 39)
                {
                    kategorie = "Fettleibig";
                }
                else if (wert > 41)
                {
                    kategorie = "Extrem fettleibig";
                }

                // Ergebnis in einem Label anzeigen
                labelErgebnis.Text = $"Wert: {wert:F2}\n // Kategorie: {kategorie}";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelErgebnis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

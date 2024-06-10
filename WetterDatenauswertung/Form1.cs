using System.Runtime.CompilerServices;

namespace WetterDatenauswertung
{
    public partial class Form1 : Form
    {
        Csv csv = new Csv();

        List<Wetterdaten> wetterdaten = new List<Wetterdaten>();

        public const string csvName = @".\Wetter.csv";
        public Form1()
        {
            InitializeComponent();
            csv.CreateFileIfNotExists(csvName);

            Update();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btHinzufügen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDate.Text) &&
                !string.IsNullOrEmpty(tbLuftfeuchtigkeit.Text) &&
                !string.IsNullOrEmpty(tbTemperatur.Text))
            {
                csv.Add(csvName, tbDate.Text + ";" + tbTemperatur.Text + ";" + tbLuftfeuchtigkeit.Text);

                Update();
            }
        }

        public void Update()
        {
            UpdateObjects();
            lbUpdate();
            tbDate.Text = DateTime.Now.ToString();
            UpdateAuswertung();
        }

        private void UpdateObjects()
        {
            List<string> csvData = csv.ToList(csvName);

            wetterdaten.Clear();

            for (int i = 0; i < csvData.Count; i++)
            {
                string[] splitetData = csvData[i].Split(';');

                Wetterdaten wetter = new Wetterdaten(splitetData[0], Convert.ToDouble(splitetData[1]), Convert.ToDouble(splitetData[2]));

                wetterdaten.Add(wetter);
            }
        }
        private void lbUpdate()
        {
            lbAusgabe.Items.Clear();

            lbAusgabe.Items.Add("Datum - Temperatur - Feuchtigkeit");

            for (int i = 0; i < wetterdaten.Count; i++)
            {
                lbAusgabe.Items.Add(wetterdaten[i].Datum + " "  + wetterdaten[i].Temperatur + " " + wetterdaten[i].Feuchtigkeit);
            }
        }

        private void UpdateAuswertung()
        {
            List<string> auswertung = new List<string>();

            auswertung.Add("Auswertung");

            double Durchschnittstemperatur = 0;
            for (int i = 0;i < wetterdaten.Count;i++)
            {
                Durchschnittstemperatur += wetterdaten[i].Temperatur;
            }
            Durchschnittstemperatur = Durchschnittstemperatur / wetterdaten.Count;

            auswertung.Add("Durchschnittstemperatur: "  + Math.Round(Durchschnittstemperatur, 1) + " C");


            double feuchtigkeit = 0;
            for (int i = 0; i < wetterdaten.Count; i++)
            {
                feuchtigkeit += wetterdaten[i].Feuchtigkeit;
            }
            feuchtigkeit = feuchtigkeit / wetterdaten.Count;

            auswertung.Add("Durchschnittsfeuchtigkeit: " + Math.Round(feuchtigkeit, 1) + " %");

            double maxTemperatur = 0;
            for (int i = 0; i < wetterdaten.Count; i++)
            {
                if (wetterdaten[i].Temperatur > maxTemperatur)
                {
                    maxTemperatur = wetterdaten[i].Temperatur;
                }
            }

            auswertung.Add("Maximaltemperatur: " + Math.Round(maxTemperatur, 1) + " C");

            double maxFeuchtigkeit = 0;
            for (int i = 0; i < wetterdaten.Count; i++)
            {
                if (wetterdaten[i].Feuchtigkeit > maxFeuchtigkeit)
                {
                    maxFeuchtigkeit = wetterdaten[i].Feuchtigkeit;
                }
            }

            auswertung.Add("Maximalfeuchtigkeit: " + Math.Round(maxFeuchtigkeit, 1) + " %");
            auswertung.Add(" ");

            int zeroToTen = 0;
            int tenToTwenty = 0;
            int twentyToThirty = 0;

            for (int i = 0;i < wetterdaten.Count; i++)
            {
                if(wetterdaten[i].Temperatur <= 10 && wetterdaten[i].Temperatur >= 0)
                {
                    zeroToTen++;
                }
                if (wetterdaten[i].Temperatur <= 20 && wetterdaten[i].Temperatur >= 10)
                {
                    tenToTwenty++;
                }
                if (wetterdaten[i].Temperatur <= 30 && wetterdaten[i].Temperatur >= 20)
                {
                    twentyToThirty++;
                }
            }
            auswertung.Add("0-10 C: " + zeroToTen + " Tage");
            auswertung.Add("10-20 C: " + tenToTwenty + " Tage");
            auswertung.Add("20-30 C: " + twentyToThirty + " Tage");
            auswertung.Add(" ");

            int tageMitfeu = 0;
            for (int i = 0; i < wetterdaten.Count; i++)
            {
                if (wetterdaten[i].Feuchtigkeit > 79)
                {
                    tageMitfeu++;
                }
            }
            auswertung.Add("Tage mit Feuchtigkeit > 79%: " + tageMitfeu + " tage");

            tbAuswertung.Lines = auswertung.ToArray();
        }
    }
}

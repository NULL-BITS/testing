using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WetterDatenauswertung
{
    public class Csv
    {
        public Csv()
        {

        }
        public void CreateFileIfNotExists(string filename)
        {
            if (!File.Exists(filename))
            {
                try
                {
                    using (FileStream fs = File.Create(filename)) ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Erstellen der Datei: " + ex.Message);
                }
            }
        }
        public List<string> ToList(string filename)
        {
            List<string> csvData = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(filename, Encoding.UTF8))
                {
                    // Liest die csv und gibt diese in einer liste zurück
                    while (!reader.EndOfStream)
                    {
                        csvData.Add(reader.ReadLine());
                    }
                }
            }
            catch
            {
                MessageBox.Show("error beim lesen der Csv");
            }
            return csvData;
        }
        public void ImportList(string filename, List<string> csvData)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename, true, Encoding.UTF8))
                {
                    // Schreibt die übergebene liste in die Csv
                    for (int i = 0; i < csvData.Count; i++)
                    {
                        writer.WriteLine(csvData[i]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Schreiben der CSV ");
            }
        }
        public void Add(string filename, string Data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename, true, Encoding.UTF8))
                {
                    // Schreibt den Übergebenen String in die Csv
                    writer.WriteLine(Data);
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Schreiben der CSV ");
            }
        }

        public void ClearFile(string filename)
        {
            try
            {
                // Löscht die gesamte csv
                File.WriteAllText(filename, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen des Inhalts der CSV-Datei: " + ex.Message);
            }
        }

        public void RemoveAt(string filename, int csvIndex)
        {
            // Löscht den Inhalt der csv nur an einer stelle
            List<string> temp = ToList(filename);

            if (temp.Count == 0)
            {
                return;
            }

            if (csvIndex < 0 || csvIndex >= temp.Count)
            {
                return;
            }

            temp.RemoveAt(csvIndex);
            ClearFile(filename);
            ImportList(filename, temp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Clase
{
    public class Date
    {
        private List<(string Question, string Answer)> dateCitite = new List<(string, string)>();
        public int currentIndex = 0;
        public int nrIntreb = 0;

        public Date(string filePath)
        {
            LoadQuizData(filePath);

        }

        private void LoadQuizData(string filePath)
        {
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(';');
                if (parts.Length == 2)
                {
                    dateCitite.Add((parts[0].Trim(), parts[1].Trim()));
                    nrIntreb++;
                }
            }
        }

        public (string Question, string Answer) GetNextQuestion()
        {
            if (currentIndex < dateCitite.Count)
                return dateCitite[currentIndex++];
            else
            {
                currentIndex = 0; // Reset the index if reached the end of the quiz data
                return ("Gata intrebari", "Gata raspunsuri");
            }
        }
    }
}

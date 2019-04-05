using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if ((initialPopulation <= 0) || (currentPopulation <= 0) || (percent <= 0) || (visitors <= 0)) throw new ArgumentException();
            int _population = initialPopulation;
            int _countYears = 0;
            double UpPopulationsInYear;
            do
            {
                UpPopulationsInYear = (_population * (percent / 100)) + visitors;
                _population += (int)UpPopulationsInYear;
                _countYears++;
            }
            while (_population <= currentPopulation);
            return _countYears;
        }
    }
}
using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStatistics
{
    public class StatisticsEngine : IStatisticsEngine

    {
    List<double> Score = new List<double>();
        public double GetAvg(List<Person> persons)
        {
            foreach (var p in persons) 
            {
            Score.Add(p.Score);
            }
        double average = Score.Average();
        return average;
        }
    }
}

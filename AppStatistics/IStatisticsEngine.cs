using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStatistics
{
    public interface IStatisticsEngine
    {
       //public double GetAvg(List<Person> person);
        public double GetAvg();
        public double GetAvg(List<Person> persons);
        double GetMax(List<Person> person);
        double GetMinimum(List<Person> person);
        double GetMode(List<Person> persons);

    }
}

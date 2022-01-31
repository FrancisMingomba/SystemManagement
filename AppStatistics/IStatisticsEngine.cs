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
       public double GetAvg(List<Person> person);
    }
}

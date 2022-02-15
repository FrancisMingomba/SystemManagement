using DataObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStatistics
{
    public class StatisticsEngine : IStatisticsEngine
    {
        public double GetAvg() 
        {
            string filePath = @"C:\Users\mingo\Desktop\SystemManagement\AppStatistics\Score.csv";

  
            StreamReader reader = null;
            if (File.Exists(filePath))
            {
                reader = new StreamReader(File.OpenRead(filePath));
                List<double> listA = new List<double>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    //foreach (var item in values)
                    //{
                        listA.Add(Convert.ToDouble(values[1]));
                        //Console.WriteLine(listA);
                    //}
                    //foreach (var coloumn1 in listA)
                    //{
                    //    Console.WriteLine(coloumn1);
                    //}                  
                }
                // var newList = Convert.ToDouble(listA);
                return listA.Average(); 
            }      
            else
            {
                Console.WriteLine("File doesn't exist");
                return -1;
            }
           
        }

        //Function to get the average of scores
        public double GetAvg(List<Person> persons)
        {
            return persons.Average(person => person.Score);     
        }
        //-------------------------------------------------------
        //public double GetAvg(List<Person> persons)
        //{
        //    List<double> score = new List<double>();
        //    foreach (var p in persons)
        //    {
        //        score.Add(p.Score);
        //    }
        //    double average = score.Average();
        //    return average;
        //}
        //-------------------------------------------------------

        public double GetMax(List<Person> person)
        {
            List<double> maxValue = new List<double>();

            foreach (var item in person)
            {
                maxValue.Add(item.Score);
            }
            double maxNumber = maxValue.Max();
            return maxNumber;
            // throw new NotImplementedException();
        }

        public double GetMinimum(List<Person> person)
        {
            List<double> minValue = new List<double>();

            foreach (var item in person)
            {
                minValue.Add(item.Score);
            }
            double y = minValue.Min();
            return y;
            //throw new NotImplementedException();
        }

        public double GetMode(List<Person> persons)
        {
            List<double> score = new List<double>();

            foreach (var p in persons)
            {
                score.Add(p.Score);
            }
            // Check if mode doesn't exit
            string x = "No mode";
            double mode = 0;
            if (score.Distinct().Count() == score.Count())
            {
                //return score[0];
                Console.Write(x);
            }
            else
            {                               //Get mode     
                double[] numbers = score.ToArray();
                mode = numbers.GroupBy(n => n).
                OrderByDescending(g => g.Count()).
                Select(g => g.Key).FirstOrDefault();
                Debug.Write(("Mode is: " + mode));
                // Console.WriteLine("Mode:" + mode);              
            }
            return mode;
            //throw new NotImplementedException();
        }
    }
}

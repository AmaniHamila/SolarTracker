using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarTracker.Entities
{
    public class SensorsParser
    {


        public DateTime toDateTime(String s)
        {
            DateTime Date;
            Date = new DateTime();
            Date = DateTime.ParseExact(s.Replace('-',' '), "dd/MM/yyyy HH/mm/ss", null);
            return Date;
        }


        public SensorsData Parse(string e)
        {
        SensorsData sd=new SensorsData();
        Char delimiter = ':';
            String[] substrings = e.Split(delimiter);
            int id = Int32.Parse(substrings[0]);
            int N = Int32.Parse(substrings[1]);
            int size = N * 3 + 3;
            int CRC = Int32.Parse(substrings[size - 1 ]);
            List<SensorsDatum> list = new List<SensorsDatum>();
            int j = 2;
            for(int i  = 0; i < N; i++)
            {
                DateTime theDate = toDateTime(substrings[i + j]);
                float temperature = float.Parse(substrings[i + j + 1], CultureInfo.InvariantCulture);
                float humidity = float.Parse(substrings[i + j + 1], CultureInfo.InvariantCulture);
                SensorsDatum datum = new SensorsDatum(ObjectId.GenerateNewId(), theDate, temperature, humidity);
                list.Add(datum);
                sd.datum = list;
                j = j + 2;
            }

            


            return sd;
        }
    }
}

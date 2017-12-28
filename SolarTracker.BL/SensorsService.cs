using SolarTracker.DAL;
using SolarTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarTracker.BL
{
    public class SensorsService
    {
        public void PublishData(SensorsData d)
        {

            SensorsDAL sensorsDal = new SensorsDAL();
            
            foreach (SensorsDatum x in d)
            {
                sensorsDal.InsertMongo(x);
            }

        }


        public void PublishString(String e)
        {
            SensorsParser parser = new SensorsParser();
            SensorsData sd = parser.Parse(e);
            PublishData(sd);
        }

        public IList<SensorsDatum> GetData()
        {
            SensorsDAL sensorsDal = new SensorsDAL();
            IList<SensorsDatum> s = sensorsDal.ReadMongo();
            return s;
        }
    }
}

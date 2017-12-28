using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarTracker.Entities
{
    public class SensorsData: IEnumerable
    {
        public List<SensorsDatum> datum = new List<SensorsDatum>();


        public IEnumerator GetEnumerator()
        {
            return datum.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return datum.GetEnumerator();
        }
    }
}

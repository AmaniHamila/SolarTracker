using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarTracker.Entities
{
    public class SensorsDatum
    {
        public ObjectId Id { get; set; }
        public float Temperature { get; set; }
        public float Humidite { get; set; }
        public DateTime Date { get; set; }
        //public string Date { get; set; }

        public SensorsDatum()
        {

        }

        public SensorsDatum(ObjectId id,DateTime theDate, float temperature, float humidity)
        {
            Id = id;           
            Temperature = temperature;
            Humidite = humidity;
            this.Date = theDate;
        }
    }
}

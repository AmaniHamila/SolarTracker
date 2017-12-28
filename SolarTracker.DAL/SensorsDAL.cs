using MongoDB.Bson;
using MongoDB.Driver;
using SolarTracker.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarTracker.DAL
{
    public class SensorsDAL
    {

        public void InsertMongo(SensorsDatum sensorsDatum)
        {
            //const string connectionString = "mongodb://localhost:27017";

            var client = new MongoClient("mongodb://localhost:27017");

            var MongoDB = client.GetDatabase("mongostart");

            var Collec = MongoDB.GetCollection<SensorsDatum>("temperature");

            //SensorsDatum sensorsDatum1 = new SensorsDatum(sensorsDatum.Id, sensorsDatum.Date, sensorsDatum.Temperature, sensorsDatum.Humidite);
            //SensorsDatum sensorsDatum1 = new SensorsDatum(ObjectId.GenerateNewId(), new DateTime(2008, 6, 1, 7, 47, 0), 10, 10);
            Collec.InsertOne(sensorsDatum);
            
        }

        public  IList<SensorsDatum> ReadMongo()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var MongoDB = client.GetDatabase("mongostart");
            
            var Collec = MongoDB.GetCollection<SensorsDatum>("temperature");


            
            return Collec.Find(_ => true)
                .ToList();
            

            //using (var cursor = await Collec.Find(new BsonDocument()).ToCursorAsync())
            //{
            //    while (await cursor.MoveNextAsync())
            //    {
            //        foreach (var doc in cursor.Current)
            //        {
            //            Console.WriteLine(doc);
            //        }
            //    }
            //}

            //var list = await Collec.Find(new BsonDocument()).ToListAsync();
            //foreach (var dox in list)
            //{
            //    Console.WriteLine(dox);
            //}

            //await Collec.Find(new BsonDocument()).ForEachAsync(X => Console.WriteLine(X));
        }
    }
}

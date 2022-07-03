/*//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using MongoDB.Driver;
using DAPS.Models;
using System;


namespace DAPS
{
internal class program1
  {
        string connectionString = "mongodb://127.0.01:27017";
        string databaseName = "simple_db";
        string collectionName = "people";

        var client = new MongoClient(connectionString);
        var db = client.GetDatabase(databaseName);
        var collection = db.GetCollection<Person>(collectionName);
        
        var person = new Person { FName = "Beshoy", LName = "corey" };
        
        await collection.InsertOneAsync(person);
        
        var results = await collection.FindAsync(_ => true);

        foreach (var result in results.ToList());
        {
    object result = null;
    Console.WriteLine(value:$"{result.Id}: {result.FName}{result.LName}");
        }
            
    }
}
*/
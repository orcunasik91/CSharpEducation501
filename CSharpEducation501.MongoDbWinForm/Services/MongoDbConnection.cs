using MongoDB.Bson;
using MongoDB.Driver;

namespace CSharpEducation501.MongoDbWinForm.Services;
public class MongoDbConnection
{
    private IMongoDatabase _database;
    public MongoDbConnection()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _database = client.GetDatabase("CoreCsharpEducationMongodb");
    }
    public IMongoCollection<BsonDocument> GetCustomersCollection()
    {
        return _database.GetCollection<BsonDocument>("Customers");
    }
}
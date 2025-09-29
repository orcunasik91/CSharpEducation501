using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CSharpEducation501.MongoDbWinForm.Models;
public class Customer
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public decimal Balance { get; set; }
    public int ShoppingCount { get; set; }
}

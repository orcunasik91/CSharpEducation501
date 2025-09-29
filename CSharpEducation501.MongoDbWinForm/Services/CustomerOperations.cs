using CSharpEducation501.MongoDbWinForm.Models;
using MongoDB.Bson;

namespace CSharpEducation501.MongoDbWinForm.Services;
public class CustomerOperations
{
    public void AddCustomer(Customer customer)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var document = new BsonDocument
        {
            {"FirstName",customer.FirstName },
            {"LastName", customer.LastName},
            {"City", customer.City },
            {"Balance",customer.Balance },
            {"ShoppingCount", customer.ShoppingCount }
        };
        customerCollection.InsertOne(document);
    }
}

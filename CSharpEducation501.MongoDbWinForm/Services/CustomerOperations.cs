using CSharpEducation501.MongoDbWinForm.Models;
using MongoDB.Bson;
using MongoDB.Driver;

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
    public List<Customer> GetAllCustomers()
    {
        var connection = new MongoDbConnection();
        var customerCollection =connection.GetCustomersCollection();
        var customers = customerCollection.Find(new BsonDocument()).ToList();
        List<Customer> customerList = new List<Customer>();
        foreach (var customer in customers)
        {
            customerList.Add(new Customer
            {
                CustomerId = customer["_id"].ToString(),
                FirstName = customer.GetValue("FirstName").AsString,
                LastName = customer.GetValue("LastName").AsString,
                City = customer.GetValue("City").AsString,
                Balance = customer.GetValue("Balance", 0).ToDecimal(),
                ShoppingCount = customer.GetValue("ShoppingCount", 0).ToInt32()
            });
        }
        return customerList;
    }
    public void DeleteCustomer(string id)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var deletedCustomer = Builders<BsonDocument>.Filter.Eq("_id",ObjectId.Parse(id));
        customerCollection.DeleteOne(deletedCustomer);
    }
    public void UpdateCustomer(Customer customer)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
        var updatedCustomer = Builders<BsonDocument>.Update
            .Set("FirstName", customer.FirstName)
            .Set("LastName", customer.LastName)
            .Set("City", customer.City)
            .Set("Balance", customer.Balance)
            .Set("ShoppingCount", customer.ShoppingCount);
        customerCollection.UpdateOne(filter, updatedCustomer);
    }
    public Customer GetOneCustomer(string id)
    {
        var connection = new MongoDbConnection();
        var customerCollection = connection.GetCustomersCollection();
        var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
        var result = customerCollection.Find(filter).FirstOrDefault();
        return new Customer
        {
            CustomerId = result.GetValue("_id").ToString(),
            FirstName = result.GetValue("FirstName").AsString,
            LastName = result.GetValue("LastName").AsString,
            City = result.GetValue("City").AsString,
            Balance = result.GetValue("Balance", 0).ToDecimal(),
            ShoppingCount = result.GetValue("ShoppingCount", 0).ToInt32()
        };
    }
}

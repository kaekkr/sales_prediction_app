using MongoDB.Bson;
using MongoDB.Driver;

public class MongoService
{
    private readonly IMongoDatabase _database;

    public MongoService(IConfiguration configuration)
    {
        var client = new MongoClient(configuration.GetConnectionString("MongoDbConnection"));
        _database = client.GetDatabase("your_database_name");
    }

    public IMongoCollection<BsonDocument> GetCollection(string collectionName)
    {
        return _database.GetCollection<BsonDocument>(collectionName);
    }
}

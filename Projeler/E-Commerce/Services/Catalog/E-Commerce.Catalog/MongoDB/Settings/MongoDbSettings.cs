namespace E_Commerce.Catalog.MongoDB.Settings;

public class MongoDbSettings : IMongoDbSettings
{
    public string DatabaseName { get; set; }
    
    public string ConnectionString { get; set; }
}
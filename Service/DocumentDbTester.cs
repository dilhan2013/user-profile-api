using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using UserProfileApi.Settings;
using MongoDB.Driver;
using UserProfileApi.DocumentModels;

namespace UserProfileApi.Service
{
    public class DocumentDbTester
    {
        private readonly DocumentDbSettings _documentDbSettings;

        public DocumentDbTester(IOptions<DocumentDbSettings> documentDbSettings)
        {
            _documentDbSettings = documentDbSettings.Value;
        }

        public Task Test()
        {
            var client = new MongoClient(_documentDbSettings.ConnectionString);
            var database = client.GetDatabase(_documentDbSettings.DatabaseName);
            var collection = database.GetCollection<UserProfile>(_documentDbSettings.CollectionName);

            return collection.InsertOneAsync(new UserProfile()
            {
                Email = "test@test.com",
                Id = Guid.NewGuid(),
                Name = "test user"
            });
        }
    }
}

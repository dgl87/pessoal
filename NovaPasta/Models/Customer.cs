using DirectOne.RogueOne.Model.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Diagnostics.CodeAnalysis;

namespace ToolsVucMigration.Models
{
    [ExcludeFromCodeCoverage]
    [BsonIgnoreExtraElements]
    public class Customer : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("connectionString")]
        public string ConnectionString { get; set; }
    }
}

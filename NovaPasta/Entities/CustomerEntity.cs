using DirectOne.RogueOne.Model.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ToolsVucMigration.Models;

namespace ToolsVucMigration.Entities
{
    [ExcludeFromCodeCoverage]
    [BsonDiscriminator("customer")]
    [BsonIgnoreExtraElements]
    public class CustomerEntity : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("documents")]
        public IDictionary<string, string> Documents { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("nickname")]
        public string NickName { get; set; }

        [BsonElement("personType")]
        public string PersonType { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; } //null

        [BsonElement("maritalStatus")]
        public string MaritalStatus { get; set; } //null

        [BsonElement("birthDate")] //Object
        public DateTime BirthDate { get; set; }

        [BsonElement("kits")]
        public List<KitModel> Kits { get; set; }

        [BsonElement("addresses")]
        public List<AddressesModel> Addresses { get; set; }
    }  
}

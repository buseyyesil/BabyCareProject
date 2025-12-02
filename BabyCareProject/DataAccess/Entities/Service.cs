using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Service
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ServiceId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        [BsonElement("Icon")]
        public string IconClass { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
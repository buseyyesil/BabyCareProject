using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class FooterSubscribe
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FooterSubscribeId { get; set; }

        public string Email { get; set; }
        public DateTime SubscribeDate { get; set; }
        public bool IsActive { get; set; }
    }
}
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Banner
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string BannerId { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }

        public string ButtonText { get; set; }

        public string ButtonUrl { get; set; }

        public int Order { get; set; }

        public bool IsActive { get; set; }
    }
}
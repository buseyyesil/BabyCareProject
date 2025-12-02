using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class FooterGallery
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FooterGalleryId { get; set; }

        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
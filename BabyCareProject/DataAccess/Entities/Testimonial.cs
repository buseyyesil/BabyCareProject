using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TestimonialId { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }  
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public int Rating { get; set; }  
        public DateTime CreatedDate { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
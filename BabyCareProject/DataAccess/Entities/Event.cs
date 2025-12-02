using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Event
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EventId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTime { get; set; }
        public string Location { get; set; }
        public int AgeRange { get; set; }  
        public int Capacity { get; set; }  
        public int Order { get; set; }
        public bool IsActive { get; set; }
    }
}
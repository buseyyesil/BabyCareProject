using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class About
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AboutId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public int YearsOfExperience { get; set; }
        public int HappyChildren { get; set; }
        public int QualifiedTeachers { get; set; }
        public int ActivePrograms { get; set; }
    }
}
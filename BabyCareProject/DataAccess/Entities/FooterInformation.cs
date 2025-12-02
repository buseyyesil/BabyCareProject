using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class FooterInformation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FooterInformationId { get; set; }

        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedInUrl { get; set; }
    }
}
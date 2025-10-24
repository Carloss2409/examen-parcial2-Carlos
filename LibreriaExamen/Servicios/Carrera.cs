using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibreriaExamen.Models
{
    public class Carrera
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")] 
        public string Nombre { get; set; } 
    }
}

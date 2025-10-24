using MongoDB.Driver;
using System.Collections.Generic;
using LibreriaExamen.Models;  // Aquí asumo que tus modelos están en esta carpeta

namespace LibreriaExamen.Servicios
{
    public class CarreraService
    {
        private readonly IMongoCollection<Carrera> _carreras;

        public CarreraService()
        {
            // Cambia esta cadena por la que tengas en tu appsettings.json si quieres inyectar la config
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("examen-parcial-2");

            _carreras = database.GetCollection<Carrera>("carreras");
        }

        public List<Carrera> Get() =>
            _carreras.Find(carrera => true).ToList();

        public Carrera Get(string id) =>
            _carreras.Find<Carrera>(carrera => carrera.Id == id).FirstOrDefault();

        // Puedes agregar métodos para Insert, Update, Delete si quieres
    }
}

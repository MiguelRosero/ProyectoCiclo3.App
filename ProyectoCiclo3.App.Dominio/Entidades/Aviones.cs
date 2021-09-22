using System;
namespace ProyectoCiclo3.App.Dominio{
    public class Aviones{
        public int id { get; set; }
        public string marca { get; set; }
        public int modelo { get; set; }
        public int numero_asientos { get; set; }
        public int numero_banos { get; set; }
        public int capacidad_maxima { get; set; }

      
    }
 
    public class Areopuertos{
        public int id { get; set; }
        public string nombre { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public int coord_x { get; set; }
        public int coord_y { get; set; }
      
    }


    public class Rutas{
        public int id { get; set; }
        public string nombre { get; set; }
        public string ciudad { get; set; }
        public int tiempo estimado { get; set; }
    }







}

using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }

        public Alumno() => Id = Guid.NewGuid().ToString();
        
    }
    
}
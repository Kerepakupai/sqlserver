using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        private string nombre;
        public string Nombre
        {
            get { return $"Copia - {nombre}";}
            set { nombre = value.ToUpper();}
        }

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public int Año { get; set; }

        public TiposEscuela Tipo { get; set; }

        // public Curso[] Cursos { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, string pais) => (Nombre, Pais) = (nombre, pais);

        public override string ToString()
        {
            return $"Nombre: {Nombre} \nPais: {Pais} \nCiudad: {Ciudad} \nTipo: {Tipo} \nAño: {Año}";
        }
        
    }
}
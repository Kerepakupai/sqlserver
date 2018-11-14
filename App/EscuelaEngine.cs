using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Academia Platzi", "Chile");
            Escuela.Ciudad = "Santiago";
            Escuela.Año = 2018;
            // escuela.Tipo = TiposEscuela.PreEscolar;

            Escuela.Tipo = (TiposEscuela)2;

            /* 
                escuela.Cursos = new Curso[] {
                    new Curso() { Nombre = "101" },
                    new Curso() { Nombre = "201" },
                    new Curso() { Nombre = "301" }
                };
            */

            Console.WriteLine(Escuela);
            CargarCursos();
            // CargarAsignaturas();
            // CargarEvaluaciones();
            var numero = GenerarNumeroAleatorio(0, 7);
            System.Console.WriteLine($"Numero Aleatorio: {numero}");

        }

        private void CargarEvaluaciones()
        {
            foreach (var c in Escuela.Cursos)
            {
                foreach (var a in c.Asignaturas)
                {
                    var nota = GenerarNumeroAleatorio(0, 7);
                }
            }
            
            GenerarNumeroAleatorio(0, 7);


        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura(){Nombre="Matematicas"},
                    new Asignatura(){Nombre="Educacion Fisica"},
                    new Asignatura(){Nombre="Castellanos"},
                    new Asignatura(){Nombre="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre = {"David", "Rafael", "Marlon", "Enrique", "Julian", "Carlos", "Eduardo"};
            string[] nombre2 = {"Smith", "Michael", "Adam", "Brad", "Arnold", "Will", "Steven"};
            string[] apellido = {"Fuentes", "Zambrano", "Colina", "Trump", "Pit", "Perez", "Barrios"};

            var listaAlumnos = from n in nombre
                               from n2 in nombre2
                               from a in apellido
                               select new Alumno{ Nombre = $"{n} {n2} {a}" }; 

            return listaAlumnos.OrderBy( (al) => al.Id ).Take(cantidad).ToList();            
        }

        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101" },
                new Curso() { Nombre = "201" },
                new Curso() { Nombre = "301" }
            };

            var newCursos = new List<Curso>()
            {
                new Curso() {Nombre = "102", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "202", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "302", Jornada = TiposJornada.Mañana}

            };

            Escuela.Cursos.AddRange(newCursos);

            Escuela.Cursos.Add(new Curso() { Nombre = "401" });

            Escuela.Cursos.RemoveAll((curso) => curso.Nombre == "201" || curso.Nombre == "301");  // Lambda

            Escuela.Cursos.RemoveAll(delegate (Curso cur)
            {
                return cur.Nombre == "401";
            });

            Random rd = new Random();

            foreach (var c in Escuela.Cursos)
            {
                int cantidadRandom = rd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }  

        private double GenerarNumeroAleatorio(int min, int max)
        {
            Random rdn = new Random();
            var rdnNUmero = rdn.NextDouble();
            var aleatorio = min + (rdn.NextDouble() * (max - min));
            var numero   = Math.Round(aleatorio, 1);

            return numero;  
        }         
    }
}
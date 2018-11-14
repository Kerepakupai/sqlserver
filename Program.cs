using System;
using System.Collections.Generic;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {

            var engine = new EscuelaEngine();

            engine.Inicializar();

            // escuela.Cursos.RemoveRange(3, 2);   // Eliminar el numero de elementos indicado desde el Index dado. 

            // escuela.Cursos.RemoveAt(1);  // Eliminar el elemento en el Index indicado

            // escuela.Cursos.Clear();   // Eliminar todos los elementos de la Lista

            imprimirCursosEscuela(engine.Escuela);
        }

        private static bool EliminarCursos(Curso curso)
        {
            return curso.Nombre == "302";
        }

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("CURSOS DE LA ESCUELA PLATZI");

            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine($"Curso: {curso.Nombre}");
                }    
            Printer.DibujarLinea(50);
            }
        }

        private static void imprimirCursosForEach(Curso[] cursos)
        {
            foreach (var curso in cursos)
            {
                Console.WriteLine(curso.Nombre);
            }
        }

        private static void imprimirCursosFor(Curso[] cursos)
        {
            for (int i = 0; i < cursos.Length; i++)
            {
                Console.WriteLine(cursos[i].Nombre);
            }
        }

        private static void imprimirCursosDoWhile(Curso[] cursos)
        {
            int count = 0;
            do
            {
                Console.WriteLine(cursos[count].Nombre);
            } while (cursos.Length > ++ count);
        }

        private static void imprimirCursosWhile(Curso[] cursos)
        {
            int count = 0;
            while (cursos.Length > count)
            {
                Console.WriteLine(cursos[count].Nombre);
                count ++;
                Console.ReadKey();
            }
        }
    }
}

using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int count = 20)
        {
            WriteLine("".PadRight(count, '='));
        }

        public static void WriteTitle(string titulo)
        {
            int tamaño = titulo.Length + 6;

            DibujarLinea(tamaño);
            WriteLine($"|  {titulo}  |");
            DibujarLinea(tamaño);
        }
    }
}
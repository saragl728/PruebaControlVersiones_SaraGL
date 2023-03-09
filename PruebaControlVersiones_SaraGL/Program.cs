namespace PruebaControlVersiones_SaraGL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Modelo prueba;
            prueba = new Modelo();
            prueba.Nombre = MeterCadena("Introducir el nombre");
            prueba.Apellidos = MeterCadena("Introducir los apellidos");

            Console.WriteLine("Sara");
        }
        static string MeterCadena(string mensaje)
        {
            string cadena;
            Console.WriteLine($"{mensaje}");
            cadena = Console.ReadLine();
            return cadena;
        }
    }
}
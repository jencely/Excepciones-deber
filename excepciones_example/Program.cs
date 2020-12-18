using System;

namespace excepciones_example
{
    // ejemplo simple excepciones
    /* public class UsoArgumentException
     {
         private static int DividirPorDos(int numero)
         {

             if ((numero % 2) == 1)
             {
                 throw new ArgumentException("El número debe ser par.", "numero");
             }

             return numero / 2;
         }

         public static void Main()
         {

             Console.WriteLine("División de 100 entre 2 es: ", DividirPorDos(100));

             try
             {

                 Console.WriteLine("13 dividido por 2 = {0}", DividirPorDos(13));
             }
             catch (ArgumentException ae)
             {
                 Console.WriteLine("Mensaje de error: `{0}`", ae.Message);
             }
         }
     }*/
    // ejemplo excepcion con herencia
    public class InvalidAgeException : Exception //Herencia 
    {
        public InvalidAgeException(String mensaje)
               : base(mensaje)
        {

        }
    }
    public class TestUserDefinedException
    {
        static void validar(int edad)
        {
            if (edad < 18)
            {
                throw new InvalidAgeException("Lo siento, su edad debe ser mayor a 18 años");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                validar(20);
            }
            catch (InvalidAgeException e) { Console.WriteLine(e); }
            Console.WriteLine("Datos correctos");
        }
    }
}

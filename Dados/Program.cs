using System;

namespace Dados
{
    class Dado
    {
        //Atributos 
        private int valor;
        private string color;

        //Constructor
        public Dado(int valor, string color)
        {
            this.valor=valor;
            this.color=color;
        }

        //metodo
        public void imprime()
        {
            Console.WriteLine("El mejor dado es: {0},{1}", valor, color);
        }

        public static Dado operator < (Dado d, Dado d2 )
        {
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Dado d1 = new Dado(rnd.Next(1,6),"verde");
            Dado d2 = new Dado(rnd.Next(1,6),"Rojo");
            Dado d3 = new Dado(rnd.Next(1,6,"Rojo");
            d1.imprime();
            d2.imprime();
            d3.imprime();
        }
    }
}

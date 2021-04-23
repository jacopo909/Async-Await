
using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] numeri = new int[101];
            Numeri(numeri);
            Console.WriteLine("inserisci il numero da cercare: ");
            int n = int.Parse(Console.ReadLine());
            Ricercanumero(n,numeri);
            Console.ReadKey();

        }
        private static void Numeri(int[] numeri)
        {
            Random r = new Random();
            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = r.Next(0, 100);
            }
        }

        private static async Task<bool> Ricercanumero(int n,int[] numeri)
        {
            bool flag = false;
            await Task.Run(() =>
            {
                for (int i = 1; i < numeri.Length; i++)
                {
                    if (n == numeri[i])
                    {
                        flag = true;
                        Console.WriteLine($"{numeri[i]} Trovato! nella posizione: {i}");
                    }
                    else
                    {
                        Console.WriteLine($"{numeri[i]} non trovato nella posizione: {i} ");
                    }
                }
              // return flag;
            });
            return flag;
            
        }
    }
}

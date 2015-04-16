using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuggaNumrericConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a message");
                var message = Console.ReadLine();
                var result = new DuggaNumreric.NumrericNumbers();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

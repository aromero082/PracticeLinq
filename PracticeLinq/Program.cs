using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var gamesList = new List<string>() { "Mario", "Zelda", "FIFA" };
            var orderList = gamesList.OrderByDescending(x => x.Length).ToList();
            foreach(var games in orderList)
            {
                Console.WriteLine(games);
            }
        }

       
    }

    
}

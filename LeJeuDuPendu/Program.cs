/**
 * Jeu du Pendu
 * 
 * author: mams789
 * date: 7/04/21
 * 
*/

using System;

namespace LeJeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Le jeux du pendu ");

          
            GameInstance game = new GameInstance();

            game.play();
            
            Console.ReadLine();

        }
    }
}

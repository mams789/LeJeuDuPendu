using System;
using System.Collections.Generic;
using System.Text;

namespace LeJeuDuPendu
{
    public class GameInstance
    {
           private int maxErrors { get; set; }
           public List<char> Guesses { get; }

           public List<char> Misses { get; }

           public List<Words> Words { get;  }

           public Words WordToGuess { get; }


           private Random rdn;

           private bool isWin { get; set; }
           private string currentWordGuessed;

           public GameInstance(int maxErrors = 10)
            {

            rdn = new Random();

            this.maxErrors = maxErrors;

            Words = new List<Words>
            {
                new Words("programmation"),
                new Words("chocolat"),
                new Words("Soleil"),

            };

            Guesses = new List<char>();
            Misses = new List<char>();

            WordToGuess = Words[rdn.Next(Words.Count)];

            Console.WriteLine($"Le mot à deviner contient {WordToGuess.Lenght} lettres");

            currentWordGuessed = PrintWordToGuess();


            }

           public GameInstance(List<Words> words, int maxErrors = 10)
            {

            rdn = new Random();

            this.maxErrors = maxErrors;

            Words = words;

            Guesses = new List<char>();
            Misses = new List<char>();

            WordToGuess = Words[rdn.Next(Words.Count)];

            Console.WriteLine($"Le mot à deviner contient {WordToGuess.Lenght} lettres ! ");

            currentWordGuessed = PrintWordToGuess();


        }

           public void play()
            {

                while (!isWin)
                {
                Console.WriteLine("Entrer une lettre : ");

                char letter = char.ToUpper(Console.ReadKey(true).KeyChar);
                int letterIndex = WordToGuess.GetIndexOf(letter);

                Console.WriteLine();
                
                if(letterIndex != -1)
                {
                    Console.WriteLine($"Bravo, vous avez trouver la lettre : {letter}");
                    Guesses.Add(letter);
                }
                else
                {
                    Console.WriteLine($"la lettre {letter} ne se trouve pas dans le mot à deviner !");
                    Misses.Add(letter);
                }

                if(Misses.Count > 0)
                {
                    Console.WriteLine($"Erreurs ({Misses.Count}) : {string.Join(", ", Misses)}");

                }

                currentWordGuessed = PrintWordToGuess();


                if(currentWordGuessed.IndexOf('_') == -1)
                {
                    isWin = true;
                    Console.WriteLine("Félicitation vous avez gagnez la partie ! ");
                    Console.ReadKey();
                }

                if(Misses.Count >= maxErrors)
                {
                    Console.WriteLine("Dommage, c'est perdu ! ");
                    Console.ReadKey();
                    break;
                }


                }

            }



           private string PrintWordToGuess()
            {
                string currentWordGuessed = "";

            for(int i = 0; i < WordToGuess.Lenght; i++)
            {
                if (Guesses.Contains(WordToGuess.Text[i]))
                {
                    currentWordGuessed += WordToGuess.Text[i];
                }
                else
                {
                    currentWordGuessed += "_";
                }
            }


            Console.WriteLine(currentWordGuessed);
            Console.WriteLine();

            return currentWordGuessed;

           }
    }
}

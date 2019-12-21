using System;
using System.Collections.Generic;
using WordCounter.Models;
namespace WordCounter.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("|| Please enter any sentence:                                  ||");
            Console.WriteLine("*****************************************************************");
            string inputSentence = Console.ReadLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("|| Please enter any word:                                      ||");
            Console.WriteLine("*****************************************************************");
            string inputWord = Console.ReadLine();
            Word_Counter word_and_sentence = new Word_Counter(inputSentence,inputWord);
            Console.WriteLine(word_and_sentence.Print());
            
        }
    }
    
}
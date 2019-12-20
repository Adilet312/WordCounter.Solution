using System;
using System.Collections.Generic;
using WordCounter.Models;
namespace WordCounter.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter any sentence: ");
            string inputSentence = Console.ReadLine();
            Console.WriteLine("Please enter any word: ");
            string inputWord = Console.ReadLine();
            Word_Counter word_and_sentence = new Word_Counter(inputSentence,inputWord);
            for(int idx = 0; idx < word_and_sentence.SplitSentenceIntoWords().Count; idx++){
            Console.WriteLine(word_and_sentence.SplitSentenceIntoWords()[idx]);
            }
            for(int idx = 0; idx < word_and_sentence.SortWordsBySize().Count; idx++)
            {
                Console.WriteLine(word_and_sentence.SortWordsBySize()[idx]);
            }
            Console.WriteLine(word_and_sentence.Print());
            
        }
    }
    
}
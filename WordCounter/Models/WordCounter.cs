using System;
using System.Collections.Generic;
namespace WordCounter.Models
{
    public class Word_Counter
    {
        private string word;
        private string sentence;
        public Word_Counter(string given_sentence, string given_word)
        {
            this.word = given_word;
            this.sentence = given_sentence+"  e";
        }
        public string GetWord()
        {
            return this.word;
        }

        public void SetWord(string new_word)
        {
            this.word = new_word;
        }

        public string GetSentence()
        {
            return this.sentence;
        }

        public void SetSentence(string new_sentence)
        {
            this.sentence = new_sentence;
        }

        public List<string> SplitSentenceIntoWords()
        {
            string split_word="";
            List<string> list = new List<string>();
            for(int idx = 0; idx < this.sentence.Length; idx++)
            {
                
                if (this.sentence[idx]==' ')
                {
                    list.Add(split_word);
                    split_word="";
                }
                else 
                {
                    split_word+=this.sentence[idx];
                }
            }

            return list;
        }
        public List<string> SortWordsBySize()
        {
            List<string> sorted_list = new List<string>();
            for(int index = 0; index < SplitSentenceIntoWords().Count; index++)
            {
                if(this.word.Length==SplitSentenceIntoWords()[index].Length)
                {
                    sorted_list.Add(SplitSentenceIntoWords()[index]);
                }
            }
            return sorted_list;
        }

        public int CountTheSameWords()
        {
            int count = 0;
            int countWords = 0;
            for(int idx = 0; idx < SortWordsBySize().Count; idx++)
            {
                string eachWord = SortWordsBySize()[idx];
                for(int index = 0; index < eachWord.Length; index++)
                { 
                    
                    if(eachWord[index]==this.word[index])
                    {
                        count++;
                    }
                }
                if(count==this.word.Length)
                {
                    countWords++;
                }
            }
            return countWords;
        }

        public string Print()
        {
            string output = "Given word: " + this.word + ", Given sentence: " + this.sentence + ", \n There is "
            +CountTheSameWords()+" in your sentence."; 
            return output;
        }

        public int GetSizeSentence()
        {
            return this.sentence.Length;
        }
    }
}
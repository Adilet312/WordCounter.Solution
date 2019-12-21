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
            this.sentence = given_sentence+" e";
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

        public string SentencePeriodsAndCommas()
        {
            string sentence_without_commas_periods = "";
            for( int index = 0; index < this.sentence.Length; index++)
            {
                if(this.sentence[index]==',' || this.sentence[index]=='.' || this.sentence[index]==':' ||
                   this.sentence[index]==';' || this.sentence[index]=='?'|| this.sentence[index]=='(' || this.sentence[index]==')')
                {
                    sentence_without_commas_periods+=' ';
                }
                else
                {
                    sentence_without_commas_periods+=this.sentence[index];
                }
            }
            return sentence_without_commas_periods;
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
                    Console.WriteLine(eachWord[index]+","+this.word[index]);
                    if(eachWord[index]==this.word[index])
                    {
                        count++;
                    }
                }
                if(count==this.word.Length)
                {
                    countWords++;
                }
                count = 0;
            }
            return countWords;
        }
        public string RestoreSentenceByRemovingLastLetter()
        {
            string userGivenSentence = "";
            for(int idx = 0; idx < this.sentence.Length-2; idx++)
            {
                userGivenSentence+=this.sentence[idx];
            }
            return userGivenSentence;
        }

        public string Print()
        {

            string output = "Given word: " + this.word + ", Given sentence: " + RestoreSentenceByRemovingLastLetter() 
            + ", \n" + CountTheSameWords() + " similar words in your sentence."; 
            return output;
        }

        public int GetSizeSentence()
        {
            return this.sentence.Length;
        }
    }
}
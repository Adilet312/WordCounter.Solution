using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter.Models;
namespace WordCounter.Tests
{
    [TestClass]
    public class Word_Counter_Tests
    {
        [TestMethod]
        public void GetUserGivenWordAndSentence()
        {
            Word_Counter word_sentence = new Word_Counter("I am a student.","Epicodus");
            string word = "Epicodus";
            string sentence = "I am a student.";
            Assert.AreEqual(word.ToLower(),word_sentence.GetWord());
            Assert.AreNotEqual(sentence.ToLower(),word_sentence.GetSentence());
            

        }

        [TestMethod]
        public void SetGivenWordAndSentence()
        {
            Word_Counter word_sentence = new Word_Counter("I am a student.","Epicodus");
            string word = "Codefellow";
            word_sentence.SetWord(word);
            string sentence = "I am a developer";
            word_sentence.SetSentence(sentence);
            Assert.AreEqual(word,word_sentence.GetWord());
            Assert.AreEqual(sentence,word_sentence.GetSentence());
            

        }


        [TestMethod]
        public void SplitSentenceIntoArray()
        {
            Word_Counter word_sentence = new Word_Counter("I am a student.","Epicodus");
            List<string> list = new List<string> {"I","am","a","student","e"};
            Assert.AreEqual(list.Count,word_sentence.SplitSentenceIntoWords().Count);//Check size of the list.
            Assert.AreEqual(list[0],word_sentence.SplitSentenceIntoWords()[0]);//Check first element of the list.
            Assert.AreEqual(list[1],word_sentence.SplitSentenceIntoWords()[1]); //Check second element of the list.
            Assert.AreEqual(list[2],word_sentence.SplitSentenceIntoWords()[2]);//Check third element of the list.
            Assert.AreEqual(list[3],word_sentence.SplitSentenceIntoWords()[3]);//Check third element of the list.
            

        }
        
        [TestMethod]
        public void CollectTheSameSizeWordsAsGivenWord()
        {
            string given_word = "at";
             Word_Counter word_sentence = new Word_Counter("I am a student and a developer at MS .",given_word);
             List<string> twoLetterWords = new List<string>{"am","at","ms"};
             Assert.AreEqual(twoLetterWords.Count,word_sentence.SortWordsBySize().Count);//Check size of the list
             Assert.AreEqual("am",word_sentence.SortWordsBySize()[0]);//Compare element of the list.
             Assert.AreEqual("at",word_sentence.SortWordsBySize()[1]);
             Assert.AreEqual("MS",word_sentence.SortWordsBySize()[2]);
        } 

        [TestMethod]

        public void CountHowmManyTimesAppearGivenWordInSentence()
        {
             string given_word = "at";
             Word_Counter word_sentence = new Word_Counter("I am a student  at the Epicdus and a developer at MS  and at Amazon.",given_word);
             Assert.AreEqual(3,word_sentence.CountTheSameWords());//Count similar words that appears in the sentence.
             
        }

        [TestMethod]

        public void CheckRestoreSentenceMethod()
        {
             string given_word = "a";
             Word_Counter word_sentence = new Word_Counter("I am a student.",given_word);
            string originalWord = "I am a student.";
            Assert.AreEqual(originalWord,word_sentence.RestoreSentenceByRemovingLastLetter());
             
             
        }

        [TestMethod]

        public void SentenceWithoutPeriodsAndCommas()
        {
             
            Word_Counter word_sentence = new Word_Counter("Lee is a student, Jane is a developer,and Noris is a boxer. They live everwhere such as: Seattle, New York and Paris.","is");
            string withoutPCS = "Lee is a student  Jane is a developer and Noris is a boxer  They live everwhere such as  Seattle  New York and Paris  e";
            Assert.AreEqual(withoutPCS,word_sentence.SentencePeriodsAndCommas());
             
             
        }

    }
    
}
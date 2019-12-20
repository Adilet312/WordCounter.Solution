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
            string sentence = "I am a student. e";
            Assert.AreEqual(word,word_sentence.GetWord());
            Assert.AreEqual(sentence,word_sentence.GetSentence());
            

        }

        [TestMethod]
        public void ChangeUserGivenWordAndSentence()
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
            List<string> list = new List<string> {"I","am","a","student."};
            Assert.AreEqual(list.Count,word_sentence.SplitSentenceIntoWords().Count);//Check size of the list
            Assert.AreEqual(list[1],word_sentence.SplitSentenceIntoWords()[1]);     //Check second element of the list
            

        }



    }
    
}
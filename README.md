# **Word Counter**

#### A Test Driven Development C# program where program determines how quikly the word appears in the sentence.
#### 12/20/19

##### By _**Adilet Momunaliev**_
&nbsp;
## **Specs**
* _The program will accept a sentence and word and returns all the words in an array by spliting each word in the sentence._
* _The program will accept a sentence and word and returns all words that have similar size as given word._
* _The program will accept a sentence and word and returns all words that match with the given word._

## **Tests**

| Spec | Input | Output |
| :----------- | :----------------------| :----------- |
| **Test 1** - Program checks object is initialized with the given inputs  | if input given "word" | "word" |
| **Test 2** - Program checks GetWord() method   | if input: "adilet" | then output: "adilet"  (pass)|
| **Test 3** - Program checks GetSentence() method   | if input: "Happy new year" | then output: "Happy new year"  (pass)|
| **Test 4** - Program checks SetWord() method   | a previous value "adilet" |if new setting value : "boom" then current value "boom"|
| **Test 5** - Program checks SetSentenced() method   | a previous value "adilet happy new year" |if new setting value : "boom boop" then current value "boom boop "|
| **Test 6** - Program checks Print() method   | if given word "Epicodus" and given sentence "I am a student." | then output: given word: "Epicodus", given  sentenced: "I am a student."|


## **Setup/Installation Requirements**

* _Open Command Line_
* _cd Desktop_
* _cd Count Word_
* _dotnet build_
* _dotnet run_

## **Known Bugs**

_No bugs at the moment._

## Support and contact details

* _adiletm@hotmail.com_

## **Technologies Used**

* _C# - for Source code_
* _Atom - To write and edit the code_
## **License**

*MIT License*
Copyright (c) 2019

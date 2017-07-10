using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Letter Counter PP2 8.3

// Count the words and letters in a users string, change first
// letter of each sentence to a uppercase.
// 
// fixed the letter counter from 8.2, it used to count puncuation
// now it only counts letter characters.
//
// 10/2/16
// CSC 253
// Allie Beckman

namespace AllieBeckman_8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            // get the users string each time the button is pressed
            string userInput = userTextBox.Text;

            // default number of words and letters is 0 if theres nothing
            int numberOfWords = 0;
            int numberOfLetters = 0;
            string cappedSentence = "";

            // call my word counting class method with the users input
            // use the method to return the number of words
            // print the number of words on the desplay screen
            countTheWords userWordsToCount = new countTheWords(userInput);
            numberOfWords = userWordsToCount.getWords();
            wordCountLabel.Text = numberOfWords.ToString();

            // call letter counting class method using user input
            // use the get letter method in that class
            // print the number of letters to string
            countTheLetters userLettersToCount = new countTheLetters(userInput);
            numberOfLetters = userLettersToCount.getLetters();
            letterCountLabel.Text = numberOfLetters.ToString();

            sentenceCap capSentence = new sentenceCap(userInput);
            cappedSentence = capSentence.getCapString();
            cappedSentenceLabel.Text = cappedSentence;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // class with a count word method and a return variable method
    public class countTheWords
    {
        // variable to hold number of words
        public int words = 0;

        // a method to count words in a string
        public countTheWords(string userInput)
        {
            /**
             * I was trying to use this to count each word but for some
             * reason it was only counting the number of spaces?? 
             * I thought I'd leave it in here incase you had time to 
             * help me puzzle it out.
             * My working code is below this comment block :)
             * 
             * (edit) - Just realized I can use this for the next programming problem.
             * 
             int i = 0;
             int length = userInput.Length;
             while (i < length)
             {
                 // counts letters
                 if (i < length && !char.IsWhiteSpace(userInput[i]))
                 {
                     i++;
                     
                 }
                 
                 // counts white spaces
                 while (i < length && char.IsWhiteSpace(userInput[i]))
                 {
                     i++;

                     if (i < length && !char.IsWhiteSpace(userInput[i]))
                     {
                         i++;
                         words++;
                     }
            }
            **/

            // regix method to count words while ignoring special characters
            var matchesByListedChars = Regex.Matches(userInput,
            @"[^\s.?,]+", RegexOptions.CultureInvariant | RegexOptions.Multiline
            | RegexOptions.IgnoreCase);

            words = matchesByListedChars.Count;

        }


        // a method to retreve the counted number of words
        public int getWords()
        {
            return words;
        }
    }

    // a class holding the methods to count the letters of the string.
    public class countTheLetters
    {
        // variable for the number of letters to be returned
        public int letters;

        // method accepting a string
        public countTheLetters(string userInput)
        {
            // a counter variable and the length of the string
            int i = 0;
            int length = userInput.Length;


            while (i < length)
            {
                // counts letters
                while (i < length && !char.IsWhiteSpace(userInput[i]))
                {
                    i++;
                    while (i < length && !char.IsPunctuation(userInput[i]))
                    {
                        i++;
                        letters++;
                    }
                    
                }
                
                // counts white spaces
                while (i < length && char.IsWhiteSpace(userInput[i]))
                {
                    i++;
                }
            }
        }

        // return letter count
        public int getLetters()
        {
            return letters;
        }
    }

    public class sentenceCap
    {
        string capString;

        public sentenceCap(string userInput)
        {
            // make an array out of strings, each index is seperated by a .
            string[] arrayOfSts = userInput.Split('.');

            // counter
            int i = 0;

            int manyOfsts = arrayOfSts.Length;

            while (i < manyOfsts)
            {
                // refrences the array of strings from user input. assigning
                // the string at index i.
                string sentence = arrayOfSts[i];


                try
                {
                    // if there is a space as the first char move to the next char
                    if (char.ToString(sentence[0]) == " ")
                    {
                        // take the first letter of the sentence and change it to uppercase
                        string a = char.ToString(sentence[1]);
                        string b = a.ToUpper();

                        // replace the lowercase letter with the uppercase one and add
                        // the rest of the sentence.
                        sentence = " " + b + sentence.Substring(2);

                    }
                    else
                    {
                        // make the first letter of the sentence uppercase.
                        sentence = char.ToUpper(sentence[0]) +
                    ((sentence.Length > 1) ? sentence.Substring(1).ToLower() : string.Empty);

                    }

                }
                catch (Exception IndexOutOfRangeException)
                {
                    // catch if there are no more sentences.
                }

                // replace the item in the array with the new uppercase sentence
                // and add a period.
                arrayOfSts[i] = sentence;
                capString += arrayOfSts[i]+".";
                i++;
            }

        }
        
        public string getCapString()
        {
            return capString;
        }
    }

}




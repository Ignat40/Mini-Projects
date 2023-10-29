using System;
using System.Data;

namespace Quiz_Game
{
    enum QuizCategories
    {
        GeneralKnowladge,
        History,
        Biology,
        Mathematic,
        Sport,

    }
    struct QuizQuestions
    {
        public string Question;
        public int Score; 
        public int CorrectAnswerIndex;
        public string[] QuestionOptions;
        public QuizCategories Categories; 
    }
    public class Program
    {
        /// <summary>
        /// Create an quiz game using C# that utilizes enums,
        /// structs, loops, and functions. The program should 
        /// allow users to answer quiz questions, track their
        /// score, and display the final score at the end of the quiz.
        /// </summary>
        public static void Main()
        {
            
        }
        public static void DisplayCategories()
        {

        }
        public static void LoadQuestions()
        {

        }
        public static void PlayQuiz()
        {

        }
        public static QuizCategories ChooseCategorie()
        {

        }
    }
}
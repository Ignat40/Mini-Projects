using System;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata;

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
        public int Points;
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
        /// 

        static QuizQuestions[] gkQuestions = new QuizQuestions[]
        {
            new QuizQuestions{Question = "How many time zones are there in Russia?",
                            Points = 5,
                            CorrectAnswerIndex = '2',
                            QuestionOptions = new string[]{"10", "16", "11", "4"}},
            new QuizQuestions{Question = "What’s the national flower of Japan?",
                            Points = 3,
                            CorrectAnswerIndex = '0',
                            QuestionOptions = new string[]{"Cherry blossom", "Pink Rose", "Idk", "Lilly"}},
            new QuizQuestions{Question = "What’s the national animal of Australia?",
                            Points = 1,
                            CorrectAnswerIndex = '1',
                            QuestionOptions = new string[]{"Spider", "Red Kengaroo", "Eagle", "Bear"}},
            new QuizQuestions{Question = "How many time zones are there in Russia?",
                            Points = 5,
                            CorrectAnswerIndex = '2',
                            QuestionOptions = new string[]{"10", "16", "11", "4"}},
            new QuizQuestions{Question = "Which of the following empires had no written language?",
                            Points = 6,
                            CorrectAnswerIndex = '3',
                            QuestionOptions = new string[]{"Roman", "Aztec", "Egyptian", "Incan"}}
        };
        QuizQuestions[] historyQuestions = new QuizQuestions[]
        {
            new QuizQuestions
            {
                Question = "In which year did World War I end?",
                Points = 5,
                CorrectAnswerIndex = '2',
                QuestionOptions = new string[]{"1917", "1918", "1919", "1920"}
            },
            new QuizQuestions
            {
                Question = "Who was the first President of the United States?",
                Points = 3,
                CorrectAnswerIndex = '1',
                QuestionOptions = new string[]{"Thomas Jefferson", "George Washington", "Abraham Lincoln", "John Adams"}
            },
            new QuizQuestions
            {
                Question = "What event is known as the fall of the Berlin Wall?",
                Points = 2,
                CorrectAnswerIndex = '3',
                QuestionOptions = new string[]{"1961", "1971", "1981", "1989"}
            },
            new QuizQuestions
            {
                Question = "Who was the famous nurse known for her work during the Crimean War?",
                Points = 4,
                CorrectAnswerIndex = '0',
                QuestionOptions = new string[]{"Florence Nightingale", "Clara Barton", "Mary Seacole", "Dorothea Dix"}
            },
            new QuizQuestions
            {
                Question = "Which ancient civilization built the Machu Picchu?",
                Points = 6,
                CorrectAnswerIndex = '2',
                QuestionOptions = new string[]{"Greek", "Roman", "Incan", "Mayan"}
            }
        };

        QuizQuestions[] biologyQuestions = new QuizQuestions[]
        {
            new QuizQuestions
            {
                Question = "What is the powerhouse of the cell?",
                Points = 5,
                CorrectAnswerIndex = '1',
                QuestionOptions = new string[]{"Nucleus", "Mitochondria", "Chloroplast", "Endoplasmic Reticulum"}
            },
            new QuizQuestions
            {
                Question = "Which gas do plants absorb during photosynthesis?",
                Points = 3,
                CorrectAnswerIndex = '2',
                QuestionOptions = new string[]{"Oxygen", "Carbon Dioxide", "Nitrogen", "Hydrogen"}
            },
            new QuizQuestions
            {
                Question = "What is the largest organ in the human body?",
                Points = 1,
                CorrectAnswerIndex = '0',
                QuestionOptions = new string[]{"Skin", "Liver", "Heart", "Lungs"}
            },
            new QuizQuestions
            {
                Question = "Which species is known as the 'father of genetics'?",
                Points = 5,
                CorrectAnswerIndex = '3',
                QuestionOptions = new string[]{"Charles Darwin", "Gregor Mendel", "Louis Pasteur", "Rosalind Franklin"}
            },
            new QuizQuestions
            {
                Question = "What is the chemical symbol for water?",
                Points = 6,
                CorrectAnswerIndex = '1',
                QuestionOptions = new string[]{"H2O", "CO2", "O2", "CH4"}
            }
        };
        QuizQuestions[] mathQuestions = new QuizQuestions[]
        {
            new QuizQuestions
            {
                Question = "What is the value of π (pi) to two decimal places?",
                Points = 5,
                CorrectAnswerIndex = '1',
                QuestionOptions = new string[]{"3.14", "3.16", "3.18", "3.12"}
            },
            new QuizQuestions
            {
                Question = "What is the square root of 144?",
                Points = 3,
                CorrectAnswerIndex = '0',
                QuestionOptions = new string[]{"12", "10", "14", "16"}
            },
            new QuizQuestions
            {
                Question = "What is the result of 5 multiplied by 8?",
                Points = 2,
                CorrectAnswerIndex = '2',
                QuestionOptions = new string[]{"35", "40", "45", "50"}
            },
            new QuizQuestions
            {
                Question = "If a = 3 and b = 7, what is the value of a + b?",
                Points = 4,
                CorrectAnswerIndex = '3',
                QuestionOptions = new string[]{"9", "10", "11", "12"}
            },
            new QuizQuestions
            {
                Question = "What is the area of a rectangle with length 6 units and width 4 units?",
                Points = 6,
                CorrectAnswerIndex = '1',
                QuestionOptions = new string[]{"20 sq units", "24 sq units", "18 sq units", "16 sq units"}
            }
        };
        QuizQuestions[] sportQuestions = new QuizQuestions[]
                {
            new QuizQuestions
            {
                Question = "Who is often referred to as 'The Greatest' in boxing?",
                Points = 5,
                CorrectAnswerIndex = '2',
                QuestionOptions = new string[]{"Muhammad Ali", "Mike Tyson", "Sugar Ray Robinson", "Floyd Mayweather"}
            },
            new QuizQuestions
            {
                Question = "Which country won the most gold medals in the 2020 Summer Olympics?",
                Points = 3,
                CorrectAnswerIndex = '1',
                QuestionOptions = new string[]{"USA", "China", "Japan", "Russia"}
            },
            new QuizQuestions
            {
                Question = "In which year did the first modern Olympic Games take place?",
                Points = 2,
                CorrectAnswerIndex = '0',
                QuestionOptions = new string[]{"1896", "1900", "1920", "1936"}
            },
            new QuizQuestions
            {
                Question = "Who holds the record for the fastest 100m sprint in athletics?",
                Points = 4,
                CorrectAnswerIndex = '3',
                QuestionOptions = new string[]{"Usain Bolt", "Carl Lewis", "Florence Griffith-Joyner", "Jamaica"}
            },
            new QuizQuestions
            {
                Question = "Which country has won the most FIFA World Cup titles?",
                Points = 6,
                CorrectAnswerIndex = '1',
                QuestionOptions = new string[]{"Brazil", "Germany", "Argentina", "Italy"}
            }
                };
        public static string categorieChoise = string.Empty;
        public static void Main()
        {
            PlayQuiz();
        }
        public static void DisplayCategories()
        {
            Console.WriteLine("WELCOME TO QUICK QUIZ GAME!");

            Console.WriteLine("Our cateogries:");
            Console.WriteLine(" * General Knowladge");
            Console.WriteLine(" * History");
            Console.WriteLine(" * Biology");
            Console.WriteLine(" * Mathematics");
            Console.WriteLine(" * Sport");
        }
        public static string ChooseCategories()
        {
            Console.WriteLine("Enter categorie you want to play: ");
            bool isChosen = false;

            while (true)
            {
                Console.WriteLine("1. General Knowladge");
                Console.WriteLine("2. History");
                Console.WriteLine("3. Biology");
                Console.WriteLine("4. Mathematics");
                Console.WriteLine("5. Sport");
                Console.Write("Choice: ");
                string? choice = Console.ReadLine();

                if (choice == "1" || choice == "2" || choice == "3"
                 || choice == "4" || choice == "5")
                {
                    isChosen = true;
                    categorieChoise = choice;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again...");
                }
            }

            return categorieChoise;

        }
        public static void LoadQuestions()
        {
            int playerScore = 0;
            int counter = 0;
            int categoryIndex = int.Parse(categorieChoise) - 1;
            while (counter <= 5)
            {
                if (categoryIndex >= 0 && categoryIndex < 5)
                {
                    Console.WriteLine("<---- QUESTION ---->");
                    Console.WriteLine($"{gkQuestions[categoryIndex].Question}");

                    Console.WriteLine("--------------------");
                    for (int i = 0; i < gkQuestions[categoryIndex].QuestionOptions.Length; i++)
                    {
                        Console.WriteLine($"{i}. {gkQuestions[categoryIndex].QuestionOptions[i]}");
                    }

                    Console.WriteLine("Answer: ");
                    string? answer = Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("Invalid category choice. Please try again...");
                    break;
                }
            }


        }
        public static void PlayQuiz()
        {
            DisplayCategories();
            Console.WriteLine("\n Do you want to play? (y/n)");
            string? yesNo = Console.ReadLine().ToLower();
            if (yesNo == "y")
            {
                ChooseCategories();
                LoadQuestions();
            }
            else if (yesNo == "n")
            {
                Console.WriteLine("BYE!");
            }
            else
            {
                Console.WriteLine("Invalid input, which means that you don't want to play!");
            }


        }

    }
}
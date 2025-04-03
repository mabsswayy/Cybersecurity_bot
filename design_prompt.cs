using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace Cybersecurity_bot
{
    public class design_prompt
    {
        //decleration[global]
        private string user_name = string.Empty;
        private string user_asking =string.Empty;
        //constructor
        public design_prompt()
        {
Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("====================================================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ WELCOME TO AI  ]");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("====================================================================");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.Write("CHATBOT:)");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PLEASE ENTER YOUR NAME");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("you:|");
            Console.ForegroundColor = ConsoleColor.Blue;
            user_name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("chatbot:)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" hey " + user_name + ", how can i help you ? ");

            
        }//end of constructor
        

class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string[] ignoredKeywords = { "please", "can", "about" };

            // Step 1: Split the input into words
            var words = userInput.Split(new[] { ' ', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            // Step 2: Filter out ignored keywords
            var filteredWords = words.Where(word => !ignoredKeywords.Contains(word.ToLower())).ToList();

            // Step 3: Process the filtered words to generate a reply
            string reply = GenerateReply(filteredWords);

            // Output the reply
            Console.WriteLine(reply);
        }

        static string GenerateReply(List<string> filteredWords)
        {
            // Simple logic to generate a reply based on filtered words
            if (filteredWords.Contains("password, phising, sql,") && filteredWords.Contains("safety"))
            {
                return "your password should always be protected and secured, use a strong password to protect your information.";
            }
            else
            {
                return "I'm sorry, I didn't understand your request.";
            }
        }
}

        //answering method
        private void answer(string asked)
        {
            if (asked != "exit")
            {
                Console.Write("chatbot :)");
                Console.ForegroundColor = ConsoleColor.Green;
               
                
            }
            else
            {
                Console.WriteLine("thank you for using AI .Sharp");
                System.Environment.Exit(0); 
            }
        }//emd of method answer
    }//end of class
}//end of namespace
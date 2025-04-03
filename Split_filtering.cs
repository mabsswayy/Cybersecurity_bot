using System;
using System.Collections;
using System.Collections.Generic;


namespace Cybersecurity_bot
{
    public class Split_filtering
    {
        private ArrayList replies = new ArrayList();
        private ArrayList ignoreWords = new ArrayList();
        private ArrayList cybersecurityKeywords = new ArrayList();



        public Split_filtering()
        {
            StoreCybersecuritykeywords();
            StoreIgnoreWords();
            StoreReplies();
        }
        public string ProcessQuestion(string question)
        {
            if (string.IsNullOrEmpty(question))
            {
                return "please enter a valid question.";
            }
            string[] words = question.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> filteredWords = new List<string>();
            foreach (var word in words)
            {
                string lowerWord = word.ToLower();
                if (!ignoreWords.Contains(lowerWord) && cybersecurityKeywords.Contains(lowerWord))
                {
                    filteredWords.Add(lowerWord);
                }

            }
            if (filteredWords.Count == 0)
            {
                return "your question doesnt seem to be related to cyber security .Ask something related to cyber securty";

            }
            HashSet<string> matchReplies = new HashSet<string>();
            foreach (var word in filteredWords)
            {
                foreach (var reply in replies) {
                    if (replies.IndexOf(ignoreWords) != -1) 
                    {
                        matchReplies.Add(word);
                    }
                }
            }
            if (replies.Count > 0)
            {
                return "possible answers:\n-" + string.Join("\n-", replies);
            }
            else
            {
                return "i can only answer cybersecurity-related question. Please try again.";
            }
        }
        private void StoreReplies()
        {
            replies.Add("password needs to bee protected.");
            replies.Add("importance of password: " + "\r\n\r\n\nPasswords are at the first line of defence against cyber threats,");
            replies.Add("structured Query language plays a crutial role in cybersecurity" + "how sql injection works");
            replies.Add("ways to deal with threats" + "\r\n\n\n\nuse a strong password and enable multi factor authentication");

        }
        private void StoreIgnoreWords()
        {
            string[] commonWords = { "what", "is", "tell", "a", "tell", "can", "i", "about", "the", "explain", "does", "to", };
            foreach (var word in commonWords) {
                ignoreWords.Add(word); }
        }
        private void StoreCybersecuritykeywords()
        {
            string[] keywords = { "password", "sql", "injection", "firewall", "hacking", "authenticate", "encryption" }
            foreach (var word in keywords) {
                cybersecurityKeywords.Add(word);
            }
        }
    }
}
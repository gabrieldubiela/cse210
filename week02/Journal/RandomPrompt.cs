    public class RandomPrompt
    {
        private readonly List<string> prompts = new()
        {
            "Who was the most important person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
            "What was the most important thing I learned today? ",
            "What was the most important thing I did for someone else today? ",
            "What was the most important thing I did for myself today? ",
            "What am I most grateful for today? ",
            "What was the biggest challenge I faced today? ",
            "How did I overcome a difficult situation today? ",
            "What made me smile today? ",
            "What did I do today that I am proud of? ",
            "What is one thing I could have done better today? ",
            "What did I learn about myself today? ",
            "What is one thing I am looking forward to tomorrow? "
        };

        public string GetRandomPrompt()
        {
            var random = new Random();
            int index = random.Next(prompts.Count);
            string prompt = prompts[index];
            prompts.RemoveAt(index);
            return prompt;
        }
    }
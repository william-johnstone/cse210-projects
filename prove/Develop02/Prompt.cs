using System;
using System.Collections.Generic;

public class Prompt
{
    public void PromptPick()
    {
        //set up variables need a random number, the prompt i'm going to return and the max number of items in the list
        Random rnd = new Random();
        string prompt = "";
        int maxRnd = 0;

        //this section creates the list.  i can keep adding prompts here and everything else will keep working
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        //this section figures out the max number of prompts and then pulls one at random to return
        maxRnd = prompts.Count();
        int numb = rnd.Next(1, maxRnd);
        prompt = prompts[numb];

       // Console.WriteLine($"count={maxRnd}");
        Console.WriteLine($"Prompt= {prompt}");
    }
    

}
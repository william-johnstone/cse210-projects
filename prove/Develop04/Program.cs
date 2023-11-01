using System;

class Program
{
    
    static void Main(string[] args)
    {
        int _menuOption = 0;
        string[] activity = {"Breathing", "Reflecting", "Listing", "Quit"};
        while (_menuOption != 4)
        {
            Console.Clear();
            Console.WriteLine($"1 - {activity[0]}");
            Console.WriteLine($"2 - {activity[1]}");
            Console.WriteLine($"3 - {activity[2]}");
            Console.WriteLine($"4 - {activity[3]}");
            _menuOption = Convert.ToInt16(Console.ReadLine());

            if (_menuOption == 1)
            {
                Activity act1 = new Activity();
                act1.ConsoleSpinner();
            }
            else if (_menuOption == 2)
            {
                Activity act1 = new Activity();
                act1.ConsoleSpinner();
            }
            else if (_menuOption == 3)
            {
                Activity act1 = new Activity();
                act1.ConsoleSpinner();
            }
            else if (_menuOption == 4)
            {
                Console.WriteLine("Goodbye.");
                break;
            }
            else
            {
                Console.WriteLine("Pick a number 1 through 4.");
            }
        }
        

        
        
    }
}
//Pedro Castaneda
//10-17-2022
//Asking Questions
//Create a program where computer asks user questions. Implement validation features

bool run = true;

while(run)
{
    string q1 = "";
    string q2 = "";
    bool validation = true;
    bool wordValid = false;
    bool secWordValid = false;
    string userInput;
    Console.WriteLine("Hello, what is your name?");
    while(!wordValid)
    {
        q1 = Console.ReadLine();
        bool isAlpha = q1.All(Char.IsLetter);
        if(isAlpha == false || string.IsNullOrEmpty(q1))
        {
            Console.WriteLine("Invalid Entry!");
            wordValid = false;
        }
        else
        {
            wordValid = true;
        }
    }
    Console.WriteLine("What time did you wake up?");
    while(!secWordValid)
    { 
        q2 = Console.ReadLine();
        if(string.IsNullOrEmpty(q2))
        {
            Console.WriteLine("Invalid Entry!");
            secWordValid = false;
        }
        else
        {
            secWordValid = true;
        }
    }
    Console.WriteLine($"Woah {q1}! {q2} is pretty early there fella!");
    Console.WriteLine();
    Console.WriteLine("Would you like to run this program again? (yes/no)");
    while(validation)
    {
        userInput = Console.ReadLine();
        if(userInput == "yes" || userInput == "y")
        {
            validation = false;
            run = true;
        }
        else if(userInput == "no" || userInput == "n")
        {
            validation = false;
            run = false;
        }
        else
        {
            Console.WriteLine("Please enter yes or no");
            validation = true;
        }
    }
    

}
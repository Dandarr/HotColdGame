//init variables
Random rnd = new Random();
int targetValue;
targetValue = rnd.Next(100);
int guessAttempt = 0;
bool isCorrectAnswer = false;
int lastGuess = 0;
int input = 0;

Console.WriteLine("I have chosen a number between 1 and 100, please guess it! \n" +
                  "Please guess a number and press [Enter]");

while (isCorrectAnswer == false)
{
    
    //ensure that its a number + convert to int32
    try 
    { 
       input = Convert.ToInt32(Console.ReadLine()); 
    }
    catch
    {
        Console.Write("Error occurred.");
    }
    //first guess
    if (guessAttempt == 0)
    {
        if ((targetValue - input) <= 10)
        {
            Console.WriteLine("Hot");
             lastGuess = input;
             guessAttempt++;
        }
        else if ((targetValue - input) >= -10)
        {
            Console.WriteLine("Hot");
             lastGuess = input;
             guessAttempt++;
        }
        else
        {
            Console.WriteLine("Cold");
             lastGuess = input;
             guessAttempt++;
        }
    }
    
    //all subsequent guesses
    else
    {
        int distance = Math.Abs(targetValue - lastGuess);
        if (input == targetValue)
        {
            Console.WriteLine("You Got It!!!! \nPress to exit");
            guessAttempt++;
            isCorrectAnswer = true;
        }
        else if (Math.Abs(input - targetValue) < distance)
        {
            Console.WriteLine("Hotter!!!");
            lastGuess = input;
            guessAttempt++;
        }
        else if (Math.Abs(input - targetValue) > distance)
        {
            Console.WriteLine("Colder :-(");
            lastGuess = input;
            guessAttempt++;
        }
        else
        {
            Console.WriteLine("I am unable to make a guess");
            guessAttempt++;
        }
    }
}

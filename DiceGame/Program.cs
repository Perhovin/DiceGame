Random number = new();
bool playAgain = true;
Console.WriteLine("Dice Game");
while (playAgain)
{
    bool Tie = true;

while (Tie)
{
    int myroll = number.Next(1, 7);
    int computerroll = number.Next(1, 7);
    Console.WriteLine($"Your Roll {myroll}");
    Console.WriteLine($"Compoter Roll {computerroll}");

    if (myroll > computerroll)
    {
    Console.WriteLine("You are won! GG");
    Tie = false;
    }
    else if (myroll < computerroll)
    {
    Console.WriteLine ("You are looser!");
    Tie = false;
    }
    else
    {
        Console.WriteLine("It's a tie! Re-rolling...");
    }

}
Console.WriteLine();
Console.WriteLine("Do you wanna play again? yes/no");
string answer = Console.ReadLine();
    if (answer == "no")
    {
    Console.WriteLine("Ok bye");
    playAgain = false;
    }
    else if (answer == "yes")
    {
    Console.WriteLine("Lets move on");
    }
    else
    {
        Console.WriteLine("Incorrect Answer GAME OVER!");
        playAgain = false;
    }
}
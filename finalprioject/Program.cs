Console.WriteLine("press any key to start menu");
Console.ReadLine();
Console.Write("Game Menu Loading...");
Thread.Sleep(1000);
Console.Write("...");
Thread.Sleep(1000);
Console.Write("...");
Thread.Sleep(1000);
Console.Write("...");
Thread.Sleep(1000);


Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Welcome to the Mega Game Selector");
Console.WriteLine("Select the number according to the game");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("1 - Number Guessr");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("2 - Rock Paper Scissors");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("3 - Catfish Simulator");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("4 - Goblin Fight");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("5 - Area Calculator");
Thread.Sleep(1000);
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("6 - Speed Calculator");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Please select your option.");
int game = int.Parse(Console.ReadLine());

if (game == 1)
{

    Console.WriteLine("Welcome to the Number Guessing Game!");
    Console.Write("Enter the range of numbers (e.g., 1-100): ");
    string input = Console.ReadLine();
    string[] range = input.Split('-'); //Splits the range given by the user to allow the code to set the min and max number

    int minNumber = int.Parse(range[0]);
    int maxNumber = int.Parse(range[1]);

    Random random = new Random();
    int secretNumber = random.Next(minNumber, maxNumber + 1);

    Console.WriteLine("I have generated a number. You have 3 attempts to guess it.");

    int attempts = 3;
    int guess;
    bool isCorrect = false;

    Console.Write("Enter your guess: ");
    guess = int.Parse(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
        isCorrect = true;
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Too low!");

        Console.Write("Enter your guess: ");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNumber)
        {
            Console.WriteLine("Congratulations! You guessed the correct number.");
            isCorrect = true;
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Too low!");

            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("You have run out of attempts. The secret number was: " + secretNumber);
            }
        }
        else
        {
            Console.WriteLine("Too high!");

            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("You have run out of attempts. The secret number was: " + secretNumber);
            }
        }
    }
    else
    {
        Console.WriteLine("Too high!");

        Console.Write("Enter your guess: ");
        guess = int.Parse(Console.ReadLine());

        if (guess == secretNumber)
        {
            Console.WriteLine("Congratulations! You guessed the correct number.");
            isCorrect = true;
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("Too low!");

            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("You have run out of attempts. The secret number was: " + secretNumber);
            }
        }
        else
        {
            Console.WriteLine("Too high!");

            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("You have run out of attempts. The secret number was: " + secretNumber);
            }
        }
    }
}

else if (game == 2)
{
    int playerScore = 0;
    int computerScore = 0;
    bool continuePlaying = true;
    Random random = new Random();


    while (continuePlaying)
    {
        Console.WriteLine("Let's play Rock-Paper-Scissors!");
        Console.WriteLine("Enter your choice: (1) Rock, (2) Paper, (3) Scissors");
        int playerChoice = int.Parse(Console.ReadLine());


        int computerChoice = random.Next(1, 4);


        string playerChoiceName = "";
        string computerChoiceName = "";


        if (playerChoice == 1)
        {
            playerChoiceName = "Rock";
        }
        else if (playerChoice == 2)
        {
            playerChoiceName = "Paper";
        }
        else if (playerChoice == 3)
        {
            playerChoiceName = "Scissors";
        }


        if (computerChoice == 1)
        {
            computerChoiceName = "Rock";
        }
        else if (computerChoice == 2)
        {
            computerChoiceName = "Paper";
        }
        else if (computerChoice == 3)
        {
            computerChoiceName = "Scissors";
        }


        Console.WriteLine("Computer chose: " + computerChoiceName);


        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((playerChoice == 1 && computerChoice == 3) ||
                 (playerChoice == 2 && computerChoice == 1) ||
                 (playerChoice == 3 && computerChoice == 2))
        {
            Console.WriteLine("You win!");
            playerScore++;
        }
        else
        {
            Console.WriteLine("Computer wins!");
            computerScore++;
        }


        Console.WriteLine("Player score: " + playerScore);
        Console.WriteLine("Computer score: " + computerScore);


        Console.WriteLine("Do you want to play again? (Y/N)");
        string playAgain = Console.ReadLine();


        if (playAgain.ToUpper() != "Y")
        {
            continuePlaying = false;
        }


        Console.WriteLine();
    }

}

else if (game == 3)
{
    Console.WriteLine("What is your age?");
    int age = int.Parse(Console.ReadLine());

    if (age == 14)
    {
        Console.WriteLine("Oh, we're the same age!");
    }
    else
    {
        Console.WriteLine("I'm 14. You're " + age + " years old. Do you have any siblings?");

        string siblingsResponse = Console.ReadLine();

        if (siblingsResponse == "yes")
        {
            Console.WriteLine("Cool! How many siblings do you have?");
        }
        else
        {
            Console.WriteLine("That's okay. Do you have any pets?");
        }
    }

    Console.WriteLine("What is your favorite film?");
    string film = Console.ReadLine();

    if (film == "The Imitation Game")
    {
        Console.WriteLine("Oh, that's a nice film!");
    }
    else
    {
        Console.WriteLine("Oh, I haven't seen " + film + ". What's it about?");
        string description = Console.ReadLine();
        Console.WriteLine("Sounds good. I'll have to check it out.");
    }

    Console.WriteLine("What is your favorite band?");
    string band = Console.ReadLine();

    if (band == "Central Cee")
    {
        Console.WriteLine("I like them too!");
    }
    else
    {
        Console.WriteLine("Oh, I don't know " + band + ". What kind of music do they play?");
        string musicType = Console.ReadLine();
        Console.WriteLine("Hmm, I'll have to give them a listen.");
    }

}

else if (game == 4)
{
    Random gen = new Random();
    Console.WriteLine("Welcome to Goblin fight!");
    Console.WriteLine("Choose your weapon");
    Console.WriteLine("Knife + Gun + Bomb");
    string weapon = Console.ReadLine();
    if (weapon == "knife")
    {
        Console.WriteLine("Nice Choice! I would of picked that as well");
        int knife = 4;
    }

    if (weapon == "gun")
    {
        Console.WriteLine("Wow! Thats a good choice. Deadly but stealthy");
        int gun = 5;
    }

    else
    {
        Console.WriteLine("Nice choice! Range and deadly at the same time!");
        int bomb = 6;
    }


    int pStrength = 3;
    int pStamina = 10;
    int pAttack;


    int gStrength = 2;
    int gStamina = 10;
    int gAttack;

    int counter = 0;
    int damage;


    while (gStamina > 0 && pStamina > 0) //why is this && (AND) and not || (OR): To make sure that both players are still alive
    {
        Console.WriteLine("Round " + counter);
        Console.WriteLine("Press enter to attack with your" + weapon);
        Console.ReadLine();// why is this here?

        int playerDie = gen.Next(1, 7); //why a seven?  Because it makes it a dice roll since 7 isnt included only 6 is
        int gobDie = gen.Next(1, 7);

        pAttack = pStrength + playerDie;
        gAttack = gStrength + gobDie;

        if (counter == 3)
        {
            Console.WriteLine("The goblin sidesteps and takes a drink from a potion before attacking with renewed vigour");
            gStamina = gStamina + 3;
            gStrength = gStrength + 1;
        }

        if (pAttack > gAttack)
        {
            damage = pAttack - gAttack; //explain what this does: This calculates the damage through the amount of attack each player dealt 
            Console.WriteLine("You use your " + weapon + " and deal " + damage + "points of damage");
            gStamina = gStamina - damage;
        }
        else if (gAttack > pAttack)
        {
            damage = gAttack - pAttack;
            Console.WriteLine("the goblin dodges your" + weapon + "and stabs you with his dagger");
            Console.WriteLine("you receive " + damage + " points of damage");
            pStamina = pStamina - damage;
        }
        else
        {
            Console.WriteLine("you parry the goblins attack but he sidesteps your attack");
        }
        counter = counter + 1;

    }

    if (gStamina <= 0)  // what would go wrong if this was an < rather than <= it will never end the game
    {
        Console.WriteLine("the goblin lies defeated in front of you");

    }
    else
    {
        Console.WriteLine("You have died ");
    }

    Console.ReadLine();//why is this here to allow the user to exit the game when they want to instead of closing the game straight away.

}

else if (game == 5)
{
    Console.WriteLine("2D or 3D");
    int shape = int.Parse(Console.ReadLine());

    if (shape == 2D)
    {
        Console.WriteLine("Enter a width");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a length");
        int length = Convert.ToInt32(Console.ReadLine());
        int area = width * length;
        Console.WriteLine("The area of the rectangle with a width of " + width + " and the length of " + length + " has the area of " + area);
    }
    else
    {
        Console.WriteLine("Enter a Width:");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Length:");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Height:");
        int height = Convert.ToInt32(Console.ReadLine());
        int volume = width * length * height;
        Console.WriteLine("The area of the cuboid with a width of " + width + " and the length of " + length + " and the height of " + height + " has the volume of " + volume);
    }
}

else if (game == 6)
{
    Console.WriteLine("Enter the Speed:");
    int speed = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the Duration:");
    int duration = Convert.ToInt32(Console.ReadLine());
    int distance = duration * speed;
    Console.WriteLine(distance);
}

Console.WriteLine("Thank you for using the Mega Game Selector!");
Console.WriteLine("Goodbye!");
Console.ReadLine();

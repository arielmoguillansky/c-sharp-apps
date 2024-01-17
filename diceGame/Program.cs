using diceGame.Game;
Random rnd = new Random();
// Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");

// string input;
// int inputNumber;
// int tries = 3;
// bool isInputNumber;

// bool isValidNumber(string input)
// {
//   return true;
// }

// int generateNumber() => rnd.Next(1, 7);
// int guessNumber = new Dice().GetDiceNumber();

// for (int i = 0; i < 3; i++)
// {
//   do
//   {
//     Console.WriteLine("Enter a number:");
//     isInputNumber = int.TryParse(Console.ReadLine(), out inputNumber);
//   }
//   while (!isInputNumber || inputNumber < 1 || inputNumber > 6);

//   if (guessNumber == inputNumber)
//   {
//     Console.WriteLine("You Win!");
//     break;
//   }
//   else
//   {
//     tries--;
//     Console.WriteLine($"Incorrect. You have {tries} tries left.");
//   }
//   if (tries == 0)
//   {
//     Console.WriteLine($"You loose!. The correct number was {guessNumber}.");
//     Console.WriteLine("Press any key to exit");
//   }
// }
// Console.ReadKey();


Dice dice = new Dice(rnd);
GuessingGame guessingGame = new GuessingGame(dice);
GameResult gameResult = guessingGame.Play();
guessingGame.PrintResult(gameResult);

Console.ReadKey();





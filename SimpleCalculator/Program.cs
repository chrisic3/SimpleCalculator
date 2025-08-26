using SimpleCalculator;

ConsoleMessages.WelcomeMessage();

// Get first name and welcome the user
ConsoleMessages.AskForFirstName();
string firstName = UserInput.GetString();
ConsoleMessages.GreetUser(firstName);

// Get their two numbers
ConsoleMessages.AskForNumber('x');
double x = UserInput.GetDouble();
ConsoleMessages.AskForNumber('y');
double y = UserInput.GetDouble();

// Get all four results
double add = Calculations.Add(x, y);
double subtract = Calculations.Subtract(x, y);
double multiply = Calculations.Multiply(x, y);
double divide = Calculations.Divide(x, y);

// Print the results
ConsoleMessages.PrintResults(add, subtract, multiply, divide);

Console.ReadLine();

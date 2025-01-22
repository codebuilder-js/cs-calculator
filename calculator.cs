using System;
class Calculator {
  static void Main() {
    int num1;
    int num2;
    int result;
    string operatorChoice;
    string calculateAgain;
     
    do {
        Console.Clear();
        
        Console.WriteLine("Welcome to the calculator program!");
        
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the operator (+, -, *, /): ");
        operatorChoice = Console.ReadLine();
        
        switch(operatorChoice){
            case "+":
                result = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + result);
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + result);
                break;
            case "/":
                result = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + result);
                break;
            default:
                Console.WriteLine("Invalid caracter, type again...");
                break;
        }
        
        Console.Write("Wish to calculate again (Y/N): ");
        calculateAgain = Console.ReadLine().ToUpper();
    } while(calculateAgain == "Y");
    
    Console.WriteLine("Exiting program...");
    Console.ReadKey();
  }
}

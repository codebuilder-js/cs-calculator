using System;
class Calculator {
  static void Main() {
    float num1;
    float num2;
    float result;
    string operatorChoice;
    string calculateAgain;
     
    do {
        Console.Clear();
        
        Console.WriteLine("Welcome to the calculator program!");
        
        Console.Write("Enter the first number: ");
        num1 = float.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        num2 = float.Parse(Console.ReadLine());
        
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
                result = num2 == 0 ? float.NaN : num1 / num2;
                
                if(float.IsNaN(result)) {
                    Console.WriteLine("Cannot divide by 0!");
                } else {
                    Console.WriteLine(num1 + " / " + num2 + " = " + result);
                }
                
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

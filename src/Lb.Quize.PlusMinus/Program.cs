
namespace Lb.Quize.PlusMinus
{
    public class Program
    {
        /// <summary>
        /// PlusMinus Challenge
        /// 
        /// https://dev.to/jessesbyers/plusminus-challenge-can-you-help-me-understand-explain-this-recursive-solution-2leh
        /// 
        /// Write a function plusMinus(num), with the num parameter being a combination of 1 or more single digits.
        /// Determine if it is possible to separate the digits with either a plus or minus sign to get the final expression 
        /// to equal zero.
        /// 
        ///        For example: if num is 35132 then it's possible to separate the digits the following way, 3 - 5 + 1 + 3 - 2,
        ///        and  this expression equals zero. Your program should return a string of the signs you used, so for this
        ///        example your    program should return the string "-++-".
        ///        
        ///        If it's not possible to get the digit expression to equal zero, return the string "not possible". 
        ///        If there are multiple ways to get the final expression to equal zero, choose the one that contains more minus
        ///        characters. For example: if num is 26712 your program should return "-+--" and not "+-+-".
        ///        Sample Test Cases
        ///        plusMinus(35132) //-++-
        ///        plusMinus(199)   //not possible
        ///        plusMinus(26712) //-+--
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            NumericInput();
        }

        static void NumericInput()
        {
            Console.WriteLine("Enter A number:");
            var numString = Console.ReadLine();
            if (int.TryParse(numString, out int num))
            {
                var p = new PlusMinusQuiz();
                Console.WriteLine("Quiz results:");
                Console.WriteLine(p.PlusMinus(num));
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Goodbye");
                }
                else 
                {
                    Console.Clear();
                    NumericInput();
                }                
            }
        }


      

    }
}
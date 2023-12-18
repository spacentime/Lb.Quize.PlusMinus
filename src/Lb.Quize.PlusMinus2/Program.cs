using System.ComponentModel;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System;
namespace Lb.Quize01
{
    internal class Program
    {
        /// <summary>
        /// PlusMinus Challenge
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
            Console.WriteLine("Hello, World!");
        }
    }
}
using System;
using System.Collections.Generic;

namespace exerciseWeek2Task1
{
    class Maths{

        // public static int MultiplyNums()
        // {
        //     int product = 4 * 8;
        //     return product;
        // } 

        public static int MultiplyNums(int num1, int num2) // parameter can only be used inside the function
        {
            int product = num1 * num2;
            return product;
        } 

        
    }

    class Program
    {
        
        static void Main(string[] args)
       /*{                     
            //Taske 1a - Write a MultiplyNums Static method and also call it from the Main Method.
            //int answer = MultiplyNums();
            //Console.WriteLine(answer);            

            Console.WriteLine(Maths.MultiplyNums(32, 2));
        } */ 
       
        {                   
            //Taske 1b - Write the same exercise and use paramaters in the method. 
            int answer = Maths.MultiplyNums(4, 8); //call the function by passing it a string value with the parameter name 
            Console.WriteLine(answer);            
        } 
        
        
        
            //Task 1c -Create a class called Maths and move the method MultiplyNums into that class.
            //Call the method from the Main() method.                   
        }
                                                             
    }


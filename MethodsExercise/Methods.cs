using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Methods
    {
        public static int Add(params int[] numbers)
        {
int add = 0;
            foreach (int num in numbers) { add += num; }
            return add;
        }
        public static int Subtract(int initial, params int[] numbers) 
        {
            int subtract = initial;
            foreach (int num in numbers) { subtract -= num; }
            return subtract;
        }
        public static int Multiply(int initial, params int[] numbers) 
           {
            int multiply = initial;
            foreach (int num in numbers) { multiply *= num; }
            return multiply;                
            }
        public static int Divide(int intitial, params int[] numbers)
        {
            int divide = intitial;
            foreach (int num in numbers) { divide /= num; }
            return divide;
        }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeRead.ConsoleApp
{
    public class WhiteBoard
    {
        public void PrintTrueOrFalse(bool isTrueOrFalse)
        {
            if (isTrueOrFalse)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public decimal Average(int[] intArr)
        {
            decimal sumIntArr = 0m;

            foreach (int x in intArr)
            {
                sumIntArr += x;
            }

            return sumIntArr / intArr.Length;
        }

        public decimal Quotient(int x, int y)
        {
            decimal decX = x; //We can implicitly convert ints to decimals
            decimal decY = y;

            return decX / decY;
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public EngineType TypeOfEngine { get; set; }
        public bool IsNew { get; set; }

        public Car()
        {
            //empty constructor
        }

        public Car(string make, string model, EngineType typeOfEngine, bool isNew)
        {
            Make = make;
            Model = model;
            TypeOfEngine = typeOfEngine;
            IsNew = isNew;
        }

    }
    public enum EngineType { Gas, Electric, Hybrid }
}
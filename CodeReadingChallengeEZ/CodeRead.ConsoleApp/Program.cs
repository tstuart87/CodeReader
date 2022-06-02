using System;
using System.Collections.Generic;

namespace CodeRead
{
    class Program
    {
        static int _iterator = 1;

        static void Main()
        {
            Challenges _key = new Challenges();

            Start();
























            // 1
            int numOne = 2;
            int numTwo = 3;

            int one = _key.Example01(numOne, numTwo);

            Print(one);

            //A: 4
            //B: 5
            //C: 2














            // 2
            numOne = 7;
            numTwo = 2;

            int two = _key.Example02(numOne, numTwo);

            Print(two);

            //A: 14
            //B: 9
            //C: 49














            // 3
            numTwo = 31;

            bool three = _key.Method03(numTwo);

            Print(three);

            //A: True
            //B: False
            //C: Odd














            // 4
            string first = "Martin";
            string middle = "Darryl";
            string last = "O'flaherty";

            string four = _key.Method04(first, middle, last);

            Print(four);

            //A: M.D.o
            //B: M.O.d
            //C: M.O.D.










            // 5
            string paper = "scissors";

            string five = _key.Method05(paper);

            Print(five);

            //A: scissors
            //B: chainsaw
            //C: rock
















            // 6
            int age = 21;

            string six = _key.Method06(age);

            Print(six);

            //A: Have a beer
            //B: Gonna need to see some ID
            //C: undefined























            // 7
            string seven = _key.Method07(19);

            Print(seven);

            //A: little
            //B: medium
            //C: extra large























            // 8
            int x = 22;
            int y = 16;
            int z = 19;

            bool eight = _key.Method08(x, y, z);

            Print(eight);

            //A: Max
            //B: True
            //C: False



















            // 9
            paper = "scissor";

            string nine = _key.Method09(paper);

            Print(nine);

            //A: scissor
            //B: rock
            //C: chainsaw

















            // 10
            x = 9;
            y = 7;
            z = 15;

            string ten = _key.Method10(x, y, z);

            Print(ten);

            //A: 15 is the Max
            //B: 7 is the MAX
            //C: 9 is the MAX


















            // 11
            int[] tomato = { 3, 4, 1, 7, 9 };

            int eleven = _key.Method11(tomato);

            Print(eleven);

            //A: 9
            //B: 3
            //C: 1


















            // 12
            decimal diameter = 4.137m;

            decimal twelve = _key.Method12(diameter);

            Print(twelve);

            //A: 25
            //B: 25.99353761580192246
            //C: 8.274567651762876287



















            // 13
            x = 9;
            y = 7;
            z = 15;

            string thirteen = _key.Method13(x, z, y);

            Print(thirteen);

            //A: 15 is the MAX
            //B: 9 is the MAX
            //C: 7 is the MAX



































            // 14
            first = "14";


            bool fourteen = _key.Method14(first);


            Print(fourteen);


            //A: Ricardo-Ignacio
            //B: True
            //C: False













            string trev = "Trevor";

            string whatevs = _key.Method13(x, y, z);





            string stuart = _key.Method13(x, y, z);

            _key.PrintFullName(trev, stuart);

            // "Trevor 15 is the MAX"




            x = 3;
            y = 5;

            int answerOne = _key.Sum(x, y);

            int answerTwo = _key.Sum(3, 4);

            int answerThree = _key.Sum(4 - 2, 5 * 3); //17
























            // 15
            List<string> stringList = new List<string> { "dog", "cat", "animal" };

            List<string> fifteen = _key.Method15(stringList);

            Print(fifteen);

            //A: { "dog", "cat", "animal" }
            //B: dog, cat, animal
            //C: System.Collections.Generic.List`1[System.String]




















            // 16
            int angleTwo = 50;
            int angleOne = 40;

            string sixteen = _key.Method16(angleTwo, 130);

            Print(sixteen);

            //A: Not a Triangle
            //B: Viable Triangle
            //C: True


















            // 17
            bool isTrevInstructor = true;

            string seventeen = _key.Method17(isTrevInstructor);

            Print(seventeen);

            //A: Do what I say.
            //B: Do what you want.
            //C: Do what you want




















            // 18
            List<string> _stringList = new List<string> { "Shrek", "Taylor D.", "Marty O.", "William C" };

            string eightteen = _key.Method18(_stringList);

            Print(eightteen);

            //A: Taylor D.
            //B: Trevor S.
            //C: William C



















            // 19
            string instructions = "add";

            int nineteen = _key.Method19(4, 3, instructions.ToUpper());

            Print(nineteen);

            //A: -1
            //B: 7
            //C: 1
















            // 20
            string nftHashCode = "34E7G89Y";

            bool twenty = _key.Method20("34E7G89Y");

            Print(twenty);

            //A: True
            //B: False
            //C: Falsy



















        }

        static void Start()
        {
            Console.Clear();

            Console.WriteLine("\nGet ready to read some code....\n\n");
            Console.ReadKey();
        }

        static void Print(int x)
        {
            Console.WriteLine($"Challenge #{_iterator} - ANSWER: {x}");
            _iterator += 1;
            Console.ReadKey();
        }

        static void Print(bool x)
        {
            Console.WriteLine($"Challenge #{_iterator} - ANSWER: {x}");
            _iterator += 1;
            Console.ReadKey();
        }

        static void Print(string x)
        {
            Console.WriteLine($"Challenge #{_iterator} - ANSWER: {x}");
            _iterator += 1;
            Console.ReadKey();
        }

        static void Print(decimal x)
        {
            Console.WriteLine($"Challenge #{_iterator} - ANSWER: {x}");
            _iterator += 1;
            Console.ReadKey();
        }

        static void Print(List<string> x)
        {


            foreach (string word in x)
            {
                Console.WriteLine($"Challenge #{_iterator} - ANSWER: {word}");
            }

            _iterator += 1;

            Console.ReadKey();
        }
    }





















    public class Challenges
    {



























        public int Example01(int x, int y)
        {
            return x + y;
        }
























        public int Example02(int x, int y)
        {
            return x * y;
        }



















        public bool Method03(int numOne)
        {
            if (numOne % 2 == 0)
            {
                return false;
            }

            return true;
        }
















        public string Method04(string first, string middle, string last)
        {
            char x = char.ToUpper(first[0]);
            char y = char.ToUpper(last[0]);
            char z = middle[0];

            string initials = $"{x}.{y}.{z}.";

            return initials;
        }















        public string Method05(string tomato)
        {
            switch (tomato)
            {
                case "rock":
                    tomato = "paper";
                    break;

                case "paper":
                    tomato = "scissors";
                    break;

                case "scissors":
                    tomato = "rock";
                    break;

                default:
                    tomato = "chainsaw";
                    break;
            }

            return tomato;
        }












        public string Method06(int age)
        {
            if (age >= 21)
            {
                return "Have a beer";
            }

            return "Gonna need to see some ID";
        }















        public string Method07(int number)
        {
            
            if (number > 10)
            {
                if (number < 5)
                {
                    return "little";
                }
                else
                {
                    return "medium";
                }
            }

            else
            {
                if (number > 20)
                {
                    return "large";
                }

                return "extra large";
            }
        }














        public bool Method08(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                if (y > z)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
















        public string Method09(string tomato)
        {
            switch (tomato)
            {
                case "rock":
                    return "paper";

                case "paper":
                    return "scissors";

                case "scissors":
                    return "rock";

                default:
                    return "chainsaw";
            }
        }


















        public string Method10(int x, int y, int z)
        {
            if (x > y || x > z)
            {
                if (y > z)
                {
                    return $"{y} is the MAX";
                }
                else
                {
                    return $"{x} is the MAX";
                }
            }

            else
            {
                return $"{z} is the MAX";
            }
        }



































        public int Method11(int[] intArr)
        {
            int answer = intArr[0];



            for (int i = 1; i > intArr.Length; i++)
            {

                if (intArr[i] > answer)
                {
                    answer = intArr[i];
                }

            }



            return answer;
        }
















        public decimal Method12(decimal radius)
        {
            decimal diameter = 2 * Convert.ToDecimal(Math.PI) * radius;

            return diameter;
        }

        // 2 x 3.14234 x 4.137 = 



        // 2*pi*r = circumference
        // 2r = diameter















        public string Method13(int x, int y, int z)
        {
            if (x > y || x > z)
            {
                if (y > z)
                {
                    return $"{y} is the MAX";
                }
                else
                {
                    return $"{x} is the MAX";
                }
            }
            else
            {
                return $"{z} is the MAX";
            }
        }












        public bool Method14(string firstName)
        {
            if (firstName.Length <= 8)

            {
                return true;
            }

            else
            {
                return false;
            }

        }











        public void PrintFullName(string first, string last)
        {
            Console.WriteLine($"{first} {last}");
        }





        public int Sum(int x, int y)
        {
            int answer = x + y;

            return answer;
        }





































        public List<string> Method15(List<string> stringList)
        {
            return stringList;
        }


























        public string Method16(decimal angleOne, decimal angleTwo)
        {
            if (angleOne + angleTwo > 180)
            {
                return "Viable Triangle";
            }
            else
            {
                return "Not a Triangle";
            }
        }
















        public string Method17(bool isInstructor)
        {
            string reply = "Do what you want.";

            switch (isInstructor)
            {
                case true:
                    reply = "Do what I say.";
                    break;
                case false:
                    reply = "nah.";
                    break;
                default:
                    return "Do whatever you want.";
            }

            return "Do what you want";
        }


























        public string Method18(List<string> stringList)
        {
            string answer = "Trevor S.";

            foreach (string word in stringList)
            {
                if (word.Length > answer.Length)
                {
                    answer = word;
                }
            }

            return answer;
        }




















        public int Method19(int x, int y, string instructions)
        {
            int answer = 5;

            switch (instructions)
            {
                case "ADD":
                    answer = Add(x, y);
                    break;
                case "SUBTRACT":
                    answer = Subtract(x, y);
                    break;
                default:
                    break;
            }

            return answer;
        }

        public int Add(int a, int b)
        {
            return a - b;
        }

        public int Subtract(int a, int b)
        {
            return a + b;
        }














        public bool Method20(string nftHashCode)
        {
            if (nftHashCode.Length >= 8)
            {
                return false;
            }
            else
            {
                if (nftHashCode == "34E7G89Y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }













    }
}

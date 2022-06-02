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
            int[] tomato = { 4, 2, 7, 3, 12, 9, 11 };

            int three = _key.Method03(tomato);

            Print(three);

            //A: 10
            //B: 11
            //C: 12


















            // 4
            int[] nums = { 11, 4, 8, 1, 7 };

            int four = _key.Method04(nums);

            Print(four);

            //A: 8
            //B: 4
            //C: 11














            // 5
            string paper = "scissors";

            string five = _key.Method05(paper);

            Print(five);

            //A: scissors
            //B: chainsaw
            //C: tomato
















            // 6
            int age = 24;

            string six = _key.Method06(age);

            Print(six);

            //A: Nah bro.
            //B: Sure, Have a beer.
            //C: Sure, have a beer.























            // 7
            List<char> x = new List<char>()
            {
                '!', ' ', '?', 'q', '5', '\n', '@'
            };

            string seven = _key.Method07(x);

            Print(seven);

            //A: No new lines
            //B: Oh hey, new line.
            //C: false























            // 8
            int[] intArr = { 2, 4, 7, 5, 2, 1 };

            bool eight = _key.Method08(intArr);

            Print(eight);

            //A: Undefined
            //B: True
            //C: False



















            // 9
            decimal[] arr = { 25m, 35m, 51m, 78m };

            int nine = _key.Method09(arr);

            Print(nine);

            //A: 0
            //B: 4
            //C: 2

















            // 10
            string aa = "aa";

            string ten = _key.Method10(aa);

            Print(ten);

            //A: aaAAAAAAAAAAAAAAAAHH!!
            //B: aaHH!!
            //C: aaAAAAAHH!!


























            // 11
            char response = 'A';
            int min = 8;

            int eleven = _key.Method11(response, min, 3);

            Print(eleven);

            //A: 9
            //B: 5
            //C: 1


























            // 12
            int fahrenheit = 77;

            string twelve = _key.Method12(101);

            Print(twelve);

            //A: "wE'Re aLl GoNnA DiE!"
            //B: "It's getting hot."
            //C: "wE'rE AlL gOnNa dIe!"























            // 13
            string info = "FRED 123 LOW AVE, INDIANA West Lafayette.";

            char thirteen = _key.Method13(info);

            Print(thirteen);

            //A: F
            //B: 1
            //C: E



































            // 14
            // bool fourteen = _key.Method14();


            // Print(fourteen);


            // //A: Ricardo-Ignacio
            // //B: True
            // //C: False






























            // // 15
            // List<string> fifteen = _key.Method15();

            // Print(fifteen);

            // //A: { "dog", "cat", "animal" }
            // //B: dog, cat, animal
            // //C: System.Collections.Generic.List`1[System.String]




















            // // 16
            // string sixteen = _key.Method16();

            // Print(sixteen);

            // //A: Not a Triangle
            // //B: Viable Triangle
            // //C: True


















            // // 17
            // string seventeen = _key.Method17();

            // Print(seventeen);

            // //A: Do what I say.
            // //B: Do what you want.
            // //C: Do what you want




















            // // 18
            // string eightteen = _key.Method18();

            // Print(eightteen);

            // //A: Taylor D.
            // //B: Trevor S.
            // //C: William C



















            // // 19
            // int nineteen = _key.Method19();

            // Print(nineteen);

            // //A: -1
            // //B: 7
            // //C: 1
















            // // 20
            // bool twenty = _key.Method20();

            // Print(twenty);

            // //A: True
            // //B: False
            // //C: Falsy



















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

        static void Print(char x)
        {
            Print(x.ToString());
        }

        static void Print(decimal x)
        {
            Console.WriteLine($"Challenge #{_iterator} - ANSWER: {x}");
            _iterator += 1;
            Console.ReadKey();
        }

        static void Print(List<string> x)
        {
            Console.Write($"Challenge #{_iterator} - ANSWER: " + "{ ");

            foreach (string word in x)
            {
                if (x.FindIndex(a => a.Contains(word)) != x.Count - 1)
                {
                    Console.Write($"{word}, ");
                }
                else
                {
                    Console.Write($"{word} ");
                }
            }

            Console.Write("}");

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



















        public int Method03(int[] intArr)
        {

            int max = intArr[0];


            foreach (int x in intArr)
            {

                if (x > max)
                {
                    max = x;
                }

            }

            return max - 2;

        }




















        public int Method04(int[] someInts)
        {
            int answer = someInts[1];

            bool isRunning = true;
            int i = 0;

            while (isRunning)
            {
                if (someInts[i] % 2 == 0)
                {
                    answer = someInts[i];
                    isRunning = false;
                }

                i += 1;
            }

            return answer;
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
                    tomato = "tomato";
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
                return "Nah bro.";
            }

            return "Sure, have a beer.";
        }






















        public string Method07(List<char> someChars)
        {
            string outcome = "No new lines.";

            for (int i = 0; i < 5; i++)
            {
                if (someChars[i] == '\n')
                {
                    outcome = "Oh hey, new line.";
                }
            }

            return outcome;
        }
























        public bool Method08(int[] numbers)
        {
            bool isMoreEvenThanOdd = false;

            int oddCount = 0;
            int evenCount = 0;

            foreach (int x in numbers)
            {
                if (x % 2 != 1)
                {
                    oddCount += 1;
                }
                else
                {
                    evenCount += 1;
                }
            }

            if (evenCount > oddCount)
            {
                isMoreEvenThanOdd = true;
            }

            return isMoreEvenThanOdd;
        }
















        public int Method09(decimal[] decArr)
        {
            int count = 0;

            for (int i = 0; i < decArr.Length; i++)
            {
                if (decArr[i] < 50.2189m)
                {
                    count += 1;
                }
                else
                {
                    count--;
                }
            }

            return count;
        }


















        public string Method10(string A)
        {
            int count = 1;

            do
            {
                A = A + "A";
                count++;
            }
            while (count < 6);

            return A + "HH!!";
        }





























        public int Method11(char input, int max, int min)
        {
            int output;

            switch (input)
            {
                case 'A':
                    return Difference(max, min);
                case 'B':
                    return Sum(max, min);
                case 'C':
                    return Product(max, min);
                default:
                    return 100;
            }
        }

        public int Sum(int x, int y) => x + y;
        public int Difference(int x, int y) => x - y;
        public int Product(int x, int y) => x * y;



















        public string Method12(int temp)
        {
            if (temp < 0)
            {
                return "wE'Re aLl GoNnA DiE!";
            }
            else if (temp < 79)
            {
                return "We'll be fine.";
            }
            else if (temp < 100)
            {
                return "It's getting hot.";
            }
            else
            {
                return "wE'rE AlL gOnNa dIe!";
            }
        }























        public char Method13(string input)
        {
            char output = ' ';
            bool isOn = true;

            while (isOn)
            {

                foreach (char x in input)
                {

                    if (x != char.ToUpper(x))
                    {
                        output = char.ToUpper(x);
                        isOn = false;
                    }

                }

            }

            return output;
        }














        // public bool Method14()
        // {

        // }























        // public List<string> Method15()
        // {

        // }


























        // public string Method16()
        // {

        // }
















        // public string Method17()
        // {

        // }


























        // public string Method18()
        // {

        // }




















        // public int Method19()
        // {

        // }
















        // public bool Method20()
        // {

        // }















    }
}

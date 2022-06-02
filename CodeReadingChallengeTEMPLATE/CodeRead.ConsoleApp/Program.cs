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
            int three = _key.Method03();

            Print(three);

            //A: 10
            //B: 11
            //C: 12














            // 4
            int four = _key.Method04();

            Print(four);

            //A: M.D.o
            //B: M.O.d
            //C: M.O.D.














            // 5
            string five = _key.Method05();

            Print(five);

            //A: scissors
            //B: chainsaw
            //C: tomato
















            // 6
            string six = _key.Method06();

            Print(six);

            //A: Have a beer
            //B: Gonna need to see some ID
            //C: undefined























            // 7
            string seven = _key.Method07();

            Print(seven);

            //A: little
            //B: medium
            //C: extra large























            // 8
            bool eight = _key.Method08();

            Print(eight);

            //A: Max
            //B: True
            //C: False



















            // 9
            string nine = _key.Method09();

            Print(nine);

            //A: scissor
            //B: rock
            //C: chainsaw

















            // 10
            string ten = _key.Method10();

            Print(ten);

            //A: 15 is the Max
            //B: 7 is the MAX
            //C: 9 is the MAX


















            // 11
            int eleven = _key.Method11();

            Print(eleven);

            //A: 9
            //B: 3
            //C: 1


















            // 12
            decimal twelve = _key.Method12();

            Print(twelve);

            //A: 25
            //B: 25.99353761580192246
            //C: 8.274567651762876287



















            // 13
            string thirteen = _key.Method13();

            Print(thirteen);

            //A: 15 is the MAX
            //B: 9 is the MAX
            //C: 7 is the MAX



































            // 14
            bool fourteen = _key.Method14();


            Print(fourteen);


            //A: Ricardo-Ignacio
            //B: True
            //C: False

























            // 15
            List<string> fifteen = _key.Method15();

            Print(fifteen);

            //A: { "dog", "cat", "animal" }
            //B: dog, cat, animal
            //C: System.Collections.Generic.List`1[System.String]




















            // 16
            string sixteen = _key.Method16();

            Print(sixteen);

            //A: Not a Triangle
            //B: Viable Triangle
            //C: True


















            // 17
            string seventeen = _key.Method17();

            Print(seventeen);

            //A: Do what I say.
            //B: Do what you want.
            //C: Do what you want




















            // 18
            string eightteen = _key.Method18();

            Print(eightteen);

            //A: Taylor D.
            //B: Trevor S.
            //C: William C



















            // 19
            int nineteen = _key.Method19();

            Print(nineteen);

            //A: -1
            //B: 7
            //C: 1
















            // 20
            bool twenty = _key.Method20();

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
























        public int Method03()
        {

        }

























        public int Method04()
        {

        }

























        public string Method05()
        {

        }
























        public string Method06()
        {

        }

























        public string Method07()
        {


        }

























        public bool Method08()
        {

        }























        public string Method09()
        {

        }
























        public string Method10()
        {

        }



























        public int Method11()
        {

        }
























        public decimal Method12()
        {

        }

























        public string Method13()
        {

        }



























        public bool Method14()
        {

        }






























        public List<string> Method15()
        {

        }



























        public string Method16()
        {

        }



























        public string Method17()
        {

        }


























        public string Method18()
        {

        }




















        public int Method19()
        {

        }


























        public bool Method20()
        {

        }

























    }
}

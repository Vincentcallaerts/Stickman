using System;


namespace Stickman
{
    class Program
    {
        static void Main(string[] args)
        {

            string head, body, legs,headfinished,bodyfinished,legsfinished,bodyfinishedextra,enter;
            head = " __o";
            body = "`\\<,";           
            legs = "O/ O";
            headfinished = "\\e/";
            bodyfinished = "`\\\\,";
            bodyfinishedextra = " I";
            legsfinished = "O/O";
            enter = "\n";
            bool running = true;
            int teller = 0;
            int teller2 = 0;

            while (running)
            {

                head =" " + head;
                body =" " + body;
                legs =" " + legs;
                headfinished = " " + headfinished;
                bodyfinished = " " + bodyfinished;
                legsfinished = " " + legsfinished;
                bodyfinishedextra = " " + bodyfinishedextra;


                Console.Write(enter);
                Console.WriteLine(head);
                Console.WriteLine(body);
                Console.WriteLine(legs);

                teller++;
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                if (teller2 == 5)
                {
                    running = false;
                }
                if (teller == 75)
                {

                    enter = enter + enter;
                    head = " __o";
                    body = "`\\<,";
                    legs = "O/ O";
                    headfinished = "\\e/";
                    bodyfinished = "`\\\\,";
                    bodyfinishedextra = " I";
                    legsfinished = "O/O";
                    teller = 0;
                    teller2++;

                }
                

            }

            Console.Write(enter);
            Console.WriteLine(headfinished);
            Console.WriteLine(bodyfinishedextra);
            Console.WriteLine(bodyfinished);
            Console.WriteLine(legsfinished);
            Console.ReadLine();

        }
    }
}

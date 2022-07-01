using System;

namespace ConsoleApp3
{
    class Program
    {
        static string MyAsk(string myText)
        {
            Console.WriteLine(myText);
            string myAnswer = Console.ReadLine();
            return myAnswer;
        }
        static int myConvert(string myText)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(myText);
            }
            catch 
            {
            }
            return result;
        }
        static int AnswerAge(string myAskAge)
        {
            int UserAge = 0;
            byte counter = 0;
            do
            {
                if (UserAge == 0)
                {
                    UserAge = myConvert(MyAsk(myAskAge));
                    counter++;
                }
                else
                {
                    counter = 3;
                }
            }
            while (counter < 3);
            return UserAge;
        }
        static void myHello(int UserAge, string Hi, string Hello,string UserName)
        {
            if (UserAge < 18)
            {
                Console.WriteLine(Hi, UserName);
            }
            else
            {
                Console.WriteLine(Hello, UserName);
            }
        }
        static void Main(string[] args)
        {
            string AskName = "Как вас зовут?", AskAge = "Сколько вам лет?", Hi = "Привет, {0}!", Hello = "Здравствуйте, {0}!";
            string UserName = MyAsk(AskName);
            int UserAge = AnswerAge(AskAge);
            myHello(UserAge, Hi, Hello, UserName);
            Console.ReadKey();
        }
    }
}

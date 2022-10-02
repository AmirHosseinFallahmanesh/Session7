using System;
//Events in C# are a mechanism that classes use to 
//send notifications or messages to other classes. 

//An event is a notification sent by an object to signal the 
//occurrence of an action
namespace Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentMark mark = new StudentMark();
            mark.goodMarkMessage += Mark_goodMarkMessage;
            mark.badMarkMessage += Mark_badMarkMessage;
            mark.AddMark(4);
        }

        private static void Mark_badMarkMessage()
        {
            Console.WriteLine("Try More");
        }

        private static void Mark_goodMarkMessage()
        {
            Console.WriteLine("Good");
        }
    }

    class StudentMark
    {
        public delegate void message();

        public event message goodMarkMessage;
        public event message badMarkMessage;

        public void AddMark(int mark)
        {
            if (mark<10)
            {
                goodMarkMessage();
            }
            else
            {
                badMarkMessage();
            }
        }
    }
}

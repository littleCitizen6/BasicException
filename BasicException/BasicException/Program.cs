using System;

namespace BasicException
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicRunner runner = new LogicRunner();
            try
            {
                runner.RunLogic1(new int[] { });
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}

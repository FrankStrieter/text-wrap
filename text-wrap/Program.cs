using System;

namespace text_wrap
{
    class main
    {
        static void Main(string[] args)
        {
            string fileName = args[0] ?? "text.txt";
            int lineSize = args[1] != "" ? int.Parse(args[1]) : 25;
            TextWrapper wrapper = new TextWrapper();
            Console.WriteLine(wrapper.Load(fileName).wrap(lineSize));
        }
    }
}

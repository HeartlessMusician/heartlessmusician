using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Symbol 
    {
        public EventHandler <char> OnKeyPressed;
        public void Run()
        {
            Console.WriteLine("Введите необходимый символ");
            char ch = (char)Console.Read();
            while (ch !='c')
            {
                OnKeyPressed(this, ch);
                ch = (char)Console.Read();
                  }
            }
        }

}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "([{}])";


            Stack<char> stk = new Stack<char>();
            stk.Push(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stk.Push(s[i]);



                }


                if (s[i] == ')')
                {
                    if (stk.Peek() == '(')
                    {
                        stk.Pop();
                    }
                    else
                    {
                        break;
                    }


                }
                else if (s[i] == ']')
                {
                    if (stk.Peek() == '[')
                    {
                        stk.Pop();
                    }
                    else
                    {
                        break;
                    }


                }
                else if (s[i] == '}')
                {
                    if (stk.Peek() == '{')
                    {
                        stk.Pop();
                    }
                    else
                    {
                        break;
                    }


                }




            }

            if (stk.Count == 0)
            {
                Console.WriteLine("Последовательность скобок корректна");
            }
            if (stk.Count != 0)
            {
                Console.WriteLine("Последовательность скобок некорректна");
            }




            Console.ReadKey();
        }
    }
}

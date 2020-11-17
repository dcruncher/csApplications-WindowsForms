using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Parenthesis_check
    {
        

        public string check_expression(string str)
        {
            Stack s1 = new Stack();
            string str1= "Correct Expression";
            foreach(var i in str)
            {
                if(openBracket(i))
                {
                    s1.Push(i);
                }
                else if(closeBracket(i))
                {
                    if (s1.Count == 0)
                    {
                        str1 = "Incorrect number of brackets";
                    }
                    else if (!isPair(Convert.ToChar(s1.Peek().ToString()), i))
                    {
                        str1 = "Parenthesis order wrong";
                    }
                    else if(isPair(Convert.ToChar(s1.Peek().ToString()), i))
                    {
                        var j = s1.Pop();
                    }
            
                }
                
            }
            if(s1.Count!=0)
            {
                str1 = "Incorrect number of brackets";
            }

            return str1;
        }

        private bool openBracket(char i)
        {
            if(i=='('||i=='['||i=='{')
            {
                return true;
            }
            return false;
        }
        private bool closeBracket(char i)
        {
            if (i == ')' || i == ']' || i == '}')
            {
                return true;
            }
            return false;
        }
        private bool isPair(char a,char b)
        {
            if(a=='('&& b==')')
            {
                return true;
            }
            else if(a == '[' && b == ']')
            {
                return true;
            }
            else if(a == '{' && b == '}')
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
   public class StackOfStrings:Stack<string>
    {
        Stack<string> Stack;

        public StackOfStrings()
        {
            Stack = new Stack<string>();
        }

        public bool IsEmpty()
        {
            if (Stack.Count==0)
            {
                return true;
            }
            return false;
        }
        public void AddRange(Stack<string> Stack)
        {
            while (Stack.Count>0)
            {
                Push(Stack.Pop());
            }
        }
    }
}

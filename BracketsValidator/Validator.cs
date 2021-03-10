using System;
using System.Collections.Generic;
namespace BracketsValidator
{
    public class Validator
    {
        public bool ValidateSequence(String sequence){
            if (sequence  == null)
                return false;
            Stack<char> stack = new Stack<char>();
            foreach(char c in sequence){
                if (c == '(')
                    stack.Push(c);
                else if (c==')'){
                    if (stack.Count == 0)
                        return false;
                    stack.Pop();
                }
            }   
            return stack.Count == 0;
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BalancedParenthesis.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// To execure balanced parenthesis
    /// </summary>
    class BalancedParenthesis
    {
        public void BalancedParenthesisDemo()
        {
            try
            {
                String expression;
                Console.WriteLine("Enter the expression");
                expression = Utility.IsExpression(Console.ReadLine());
                Stack<char> brackets = new Stack<char>();
                foreach(char c in expression)
                {
                    if (c == '(')
                    {
                        brackets.Push(c);
                    }
                    if(c == ')')
                    {
                        brackets.Pop();
                    }
                }
                if (brackets.Count==0)
                {
                    Console.WriteLine("The expression is balanced");
                }
                else
                {
                    Console.WriteLine("The expression is not balanced");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Process could noit be comnpleted as " + e);
            }
        }
    }
        
}

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
    /// To execute balanced parenthesis
    /// </summary>
    public class BalancedParenthesis
    {
        /// <summary>
        /// To execute the balanced parenthesis demo.
        /// </summary>
        public void BalancedParenthesisDemo()
        {
            try
            {
                //// string to store the expression
                string expression;
                Console.WriteLine("Enter the expression");
                expression = Utility.IsExpression(Console.ReadLine());
                //// self implemented Linked list
                LinkedListClass brackets = new LinkedListClass();
                foreach (char c in expression)
                {
                    //// If open found its pushed
                    switch (c)
                    {
                        case '(':
                            brackets.Push(c);
                            break;

                        //// if closed parenthesis encountered it pops the open parenthesis
                        case ')':
                            switch (brackets.Pop())
                            {                               
                                case false:
                                    Console.WriteLine("Already empty equation not balanced");
                                    return;
                            }   

                            break;
                        case '{':
                            brackets.Push(c);
                            break;
                        case '}':
                            switch (brackets.Pop())
                            {
                                case false:
                                    Console.WriteLine("Already empty equation not balanced");
                                    return;
                            }

                            break;
                        case '[':
                            brackets.Push(c);
                            break;
                        case ']':
                            switch (brackets.Pop())
                            {
                                case false:
                                    Console.WriteLine("Already empty equation not balanced");
                                    return;
                            }

                            break;
                    }
                    //// if stack empty then parenthesis are balanced                    
                }

                if (brackets.IsEmpty())
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

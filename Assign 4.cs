﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEE
{
    class UserException
    {
        public static void Main()

        {
            Push_pop pp = new Push_pop();

            pp.Push(55);
            pp.Push(25);
            pp.Push(30);
            pp.Push(40);
            pp.Push(50);
            pp.Push(60);
            //    pp.Push(70);
            pp.print();
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
       //     Console.WriteLine("Element removed from stack:" + pp.Pop());

            //pp.print();


        }
    }


    public class Push_pop
    {



        int[] arr = new int[5];

        int top = 0;



        public void Push(int data)

        {
            try
            {
                if (top == 5)
                {
                    throw new StackException (" User defined Stack Exception : over flow Exception");
                }


                else
                {
                    arr[top] = data;
                    top++;
                }

            }
            catch (Exception)
            {
                return;

            }
        }

        public void print()
        {

            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int Pop()
        {
            if (top <= 0)
            {
                throw new StackException("user Defined Stack Exception : Under flow");
            }
            else
            {
                int temp = arr[top - 1];
                top--;

                return temp;
            }
        }
    }

    class StackException : Exception
    {
        public StackException(String message) : base(message)
        {
            Console.WriteLine(message);
        }

    }


}








﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    public class Stack<T>
    {
        private int top; // location of top element
        private T[] elements; // array that stores stack elements

        // parameterless constructor creates a stack of the default size
        public Stack() : this(10) // default stack size
        {
            // empty constructor; calls constructor at line 19 to perfome initialiaztion
        }

        // constructor creates a stack of the specified number of elements
        public Stack(int stackSize)
        {
            if (stackSize <= 0) // validate stackSize
            {
                throw new ArgumentException("Stack size must be positive.");
            }
            elements = new T[stackSize];
            top = -1;
        }

        // push element into the stack; if unsuccessful,
        // throw FullStackExeption
        public void Push(T pushValue)
        {
            if (top == elements.Length - 1)
            {
                throw new FullStackException($"Stack is full, cannot push{pushValue}");
            }

            ++top; // increment top
            elements[top] = pushValue; // place pushValue on stack
        }

        // return he top elemt if not empty,
        // else throw EmptyStackException

        public T Pop()
        {
            if(top == -1)
            {
                throw new EmptyStackException(" Stack is empty, cannot pop");
            }

            --top; // decrement top
            return elements[top+1]; // return top value
        }
    }
}

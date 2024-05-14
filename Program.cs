using System;
using System.Numerics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;

namespace OOP_laba1
{
    class Tree<T>
    {
        private T _value;

        private List<Tree<T>> list_reference = new List<Tree<T>>();

        public Tree(T value = default(T))
        {
            _value = value;
        }

        public void Outputree()
        {
            Console.WriteLine($"{_value.ToString()} ");

            if (list_reference == null || list_reference.Count == 0)
            {
                return;
            }

            else
            {
                for (int i = 0; i < list_reference.Count(); i++)
                {
                    list_reference[i].Outputree();
                }
            }
        }

        public void AddChildNode(T value)
        {
            _AddChildNode(value);
        }

        private int _AddChildNode(T value)
        {
            Tree<T> current = new Tree<T>(value);

            if (list_reference.Count() < 5)
            {
                list_reference.Add(current);
                return 1;
            }
            else
            {
                for (int i = 0; i < list_reference.Count(); i++)
                {
                    if (list_reference[i]._AddChildNode(value) == 1)
                        return 1;
                    else 
                        continue;
                }
            }
            return 1;
        }
    }




















    class Programm
    {
        static void Main()
        {
        }
    }

}
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Collections_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrList
            var arrList = new ArrayList();
            arrList.Add(1998);
            arrList.Add("Maqsud");
            arrList.Add(' ');
            arrList.Add(false);
            arrList.Add(13.8);
            arrList.Add(null);

            Console.WriteLine(arrList.Contains(null));
            arrList.Reverse();
            arrList.Remove(null);
            arrList.RemoveAt(0);
            arrList.RemoveRange(0,1);
            arrList.Insert(0, arrList);
            arrList.InsertRange(0, arrList);


            var arrList2 = new ArrayList()
            {
                34,"Alma",' ',56,45,null,null,false
            };

            arrList2.IndexOf(false);
            arrList2.ToArray();
            var arrList3 = new ArrayList();
            arrList3.Sort();

            //Stack

            Stack<int> newStack = new Stack<int>();
            newStack.Push(10);
            newStack.Push(30);
            newStack.Push(55);
            newStack.Push(80);

            Console.WriteLine(newStack.Contains(10));
            Console.WriteLine(newStack.Contains(3422));

            foreach (var item in newStack)
            {
                Console.WriteLine(item);
            }
            while (newStack.Count > 2)
                Console.WriteLine(newStack.Pop());

            int[] numbers = new int[] { 9670867, 390243, 46433, 345 };
            Stack<int> newStack2 = new Stack<int>(numbers);
            Console.WriteLine($"Eded sayi: {newStack2.Count}");

            foreach (var item in newStack2)
            {
                Console.WriteLine($"Eded: {item}");
            }

            if (newStack2.Count > 0)
            {
                foreach (var item in newStack2)
                {
                    Console.WriteLine(newStack2.Peek());
                }
            }

            //Sort

            SortedList<int, string> numsNames = new SortedList<int, string>();
            numsNames.Add(24, "Resad");
            numsNames.Add(32, "Tural");
            numsNames.Add(19, "Amin");
            numsNames.Add(25, "Maqsud");

            foreach (var item in numsNames)
            {
                Console.WriteLine(item);
            }

            SortedList<string, int> numsNames2 = new SortedList<string, int>();
            numsNames2.Add("Resad", 24);
            numsNames2.Add("Tural", 32);
            numsNames2.Add("Amin", 19);
            numsNames2.Add("Maqsud", 25);

            foreach (var item in numsNames2)
            {
                Console.WriteLine(item);
            }

            //Queue

            Queue<int> newQueue = new Queue<int>();
            newQueue.Enqueue(5464);
            newQueue.Enqueue(27654);
            newQueue.Enqueue(65743);
            newQueue.Enqueue(44564);

            foreach (var item in newQueue)
            {
                Console.WriteLine(item);
            }

            Queue<string> nameStr = new Queue<string>();
            nameStr.Enqueue("M");
            nameStr.Enqueue("A");
            nameStr.Enqueue("Q");
            nameStr.Enqueue("S");
            nameStr.Enqueue("U");
            nameStr.Enqueue("D");

            while (nameStr.Count > 0)
            {
                Console.WriteLine(nameStr.Dequeue());
            }
            Console.WriteLine(nameStr.Contains("A"));//Burda niye false verdi basa dusmedim
            Console.WriteLine(nameStr.Contains("Y"));

            IDictionary<string, string> newDic = new Dictionary<string, string>();
            newDic.Add("Maqsud", "+994508338883");
            newDic.Add("Tural", "+994993893929");
            newDic.Add("Resad", "+994502102999");
            newDic.Add("Amin", "+994516863003");

            foreach (var item in newDic)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(newDic.ContainsKey("Maqsud"));
            Console.WriteLine(newDic.ContainsKey("Gulmemmed"));

            newDic.Remove("Maqsud");
            newDic.Clear();

            //List

            List<int> nums = new List<int>();
            nums.Add(34534);
            nums.Add(445362);
            nums.Add(324354);
            nums.Add(8435349);
            nums.Remove(34534);
            nums.RemoveAt(1);

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }

            List<string> names = new List<string>();
            names.Add("Maqsud");
            names.Add("Tural");
            names.Add("Resad");
            names.Add("Amin");

            Console.WriteLine(names.Contains("Maqsud"));
            Console.WriteLine(names.Contains("Guleli"));
            Console.WriteLine(names.BinarySearch("Guleli"));
            Console.WriteLine(names.BinarySearch("Maqsud"));
            Console.WriteLine(names.IndexOf("Maqsud"));
            Console.WriteLine(names.Count);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string[] names2 = new string[3];
            names2[0] = "Aynur";
            names2[1] = "Gulane";
            names2[2] = "Ayse";
            names2[3] = "Vusale";
            names2[4] = "Feride";

            List<string> names2List = new List<string>(names2);
            names2List.Clear();

        }
    }
}
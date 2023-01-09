using System;
using System.Reflection;

namespace Homework_11_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStringList names = new MyStringList();
            names.Add("Maqsud");
            names.Add("Amin");
            names.Add("Resad");
            names.Add("Tural");
            names.Remove("Maqsud");
            names.RemoveAt(1);

            MyIntList numberList = new MyIntList();

            numberList.Add(123);
            numberList.Add(432);
            numberList.Add(1432);
            numberList.Add(43214);
            numberList.Add(6757);
            numberList.Remove(6757);
            numberList.RemoveAt(3);

            MyHumanList humanList = new MyHumanList();

            humanList.Add(new Human {Age=25,FullName="Maqsud" });
            humanList.Add(new Human { Age = 32, FullName = "Tural" });
            humanList.Add(new Human { Age = 19, FullName = "Amin" });
            humanList.Add(new Human { Age = 24, FullName = "Resad" });
            humanList.RemoveAt(1);

            MyList<string> myListNames = new MyList<string>();

            myListNames.Add("Maqsud");
            myListNames.Add("Tural");
            myListNames.Add("Amin");
            myListNames.Add("Resad");
            myListNames.Remove("Maqsud");
            myListNames.RemoveAt(1);

            MyList<int> myListNumbers = new MyList<int>();

            myListNumbers.Add(5464);
            myListNumbers.Add(8756856);
            myListNumbers.Add(345345);
            myListNumbers.Add(897897);
            myListNumbers.Remove(5464);
            myListNumbers.RemoveAt(1);

            DataStore<string, string> phoneNumbersBook = new DataStore<string, string>();

            phoneNumbersBook.Add("Maqsud", "+994508338883");
            phoneNumbersBook.Add("Tural", "+994993893929");
            phoneNumbersBook.Add("Resad", "+994502102999");
            phoneNumbersBook.Add("Amin", "+994516863003");

            DataStore<string, int> studentsPoints = new DataStore<string, int>();

            studentsPoints.Add("Maqsud", 50);
            studentsPoints.Add("Amin", 70);
            studentsPoints.Add("Resad", 80);
            studentsPoints.Add("Tural", 100);
        }
    }
}

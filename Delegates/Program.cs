﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Math math = new Math();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.ShowAlert;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            MyDelegate3 myDelegate3 = math.Topla;
            myDelegate3 += math.Carp;
            int sonuc = myDelegate3(2,3);
            Console.WriteLine(sonuc);

            myDelegate2("Hello!");


            myDelegate();
            Console.ReadLine();
        }
        public class CustomerManager
        {
            public void SendMessage()
            {
                Console.WriteLine("Hello!");
            }
            public void ShowAlert()
            {
                Console.WriteLine("Be careful!");
            }
            public void SendMessage2(string message)
            {
                Console.WriteLine(message);
            }
            public void ShowAlert2(string alert)
            {
                Console.WriteLine(alert);
            }
        }
        public class Math
        {
            public int Topla(int sayi1,int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int Carp(int sayi1,int sayi2)
            {
                return sayi1 * sayi2;
            }
        }
    }
}

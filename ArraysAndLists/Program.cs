using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {

        List<string> intList = new List<string> {"It is 40 degrees celsius"};
        intList.Add(" Why ");
        intList.Add("is it");
        intList.Add(" so hot today");

        
        Console.WriteLine(intList[0]+intList[1]+intList[2]+intList[3]);
        Console.ReadLine();

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();

        }
    }


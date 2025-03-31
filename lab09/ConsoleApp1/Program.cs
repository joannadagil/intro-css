using System;
using System.IO;

namespace ConsoleApp1
{
    public struct Type
    {
        public int id;
        public int year;
        public int avg;
    }

    public class Type2
    {
        public int id;
        public int year;
        public int avg;

        public Type2(int id, int year, int avg)
        {
            this.id = id;
            this.year = year;
            this.avg = avg;
        }

        public void print()
        {
            Console.WriteLine(id + "    " + year + "    " + avg);
        }
    }
    class Program
    {
        static void write(StreamWriter writetext, Type[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                writetext.WriteLine(arr[i].id + " " + arr[i].year + " " + arr[i].avg);
        }

        static void write(StreamWriter writetext, Type[] arr, int i)
        {
            writetext.WriteLine(arr[i].id + " " + arr[i].year + " " + arr[i].avg);
            if (i > 0) write(writetext, arr, i - 1);            
        }

        static void read(StreamReader readtext, Type2[] arr)
        {
            string readText = readtext.ReadLine();
            int i = 0;
            while (readText != null)
            {
                string[] values = readText.Split(' ');
                arr[i].id =   Int32.Parse(values[0]);
                arr[i].year = Int32.Parse(values[1]);
                arr[i].avg =  Int32.Parse(values[2]);

                readText = readtext.ReadLine();
                i++;
            }
        }

        static void Main(string[] args)
        {
            int size = 6;
            Type[] arr = new Type[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].id = i;
                arr[i].year = 2000;
                arr[i].avg = 5 + i;
            }
            using (StreamWriter writetext = new StreamWriter("write.txt"))
                write(writetext, arr);
            //write(arr, arr.Length-1);

            Type2[] arr2 = new Type2[size];
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = new Type2(0,0,0);
            
            using (StreamReader readtext = new StreamReader("write.txt"))
                read(readtext, arr2);

            for (int i = 0; i < arr2.Length; i++)
                arr2[i].print();
            
        }
    }
}

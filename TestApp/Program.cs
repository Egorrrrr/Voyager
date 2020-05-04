using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] f;
                string a = openFileDialog1.FileName;
                StreamReader b = new StreamReader(a);
                string c = "t";

                c = b.ReadToEnd();
                string[] h = c.Split('\n');
                string[] h2 = h[0].Split(' ');
                f = new int[h2.Length, h.Length];
                for (int i = 0; i < h.Length; i++)
                {
                    string[] r = h[i].Split(' ');

                    for (int j = 0; j < h.Length; j++)
                    {
                        f[i, j] = int.Parse(r[j]);
                    }
                }
                for (int i = 0; i < h.Length; i++)
                {
                    for (int j = 0; j < h.Length; j++)
                    {
                        Console.WriteLine(f[i, j]);
                    }
                    Console.WriteLine();
                }

            }
            catch (Exception)
            {
                Console.WriteLine(label1.Text = "error");
            }
        }
    }
}

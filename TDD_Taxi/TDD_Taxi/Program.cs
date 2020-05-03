using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Failed!");
                return;
            }
            else
            {
                string receipt = "";
                string path = args[0];
                if (!File.Exists(path))
                {
                    Console.WriteLine("Failed!");
                    return;
                }
                else
                {
                    var data = File.ReadAllLines(path);
                    if (data == null)
                    {
                        Console.WriteLine("Failed!");
                        return;
                    }
                    else
                    {
                        for (int i = 0; i < data.Length; i++)
                        {
                            var distanceTimePair = new ArgsHelper().GetArgs(data[i]);
                            receipt += "收费"+new Taximeter().GetCost(distanceTimePair[0], distanceTimePair[1]) + "元\n";
                        }
                        Console.WriteLine(receipt);
                    }
                }
            }
        }
    }
}

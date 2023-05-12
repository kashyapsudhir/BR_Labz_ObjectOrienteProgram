using System;

namespace OOPS_Problem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello OOPs Programing");


            string path = "F:\\BridgeLabzFolder\\BridgelabzAssignment\\ObjecteOrientedProgram\\BR_Labz_ObjectOrienteProgram\\OOPS_Problem\\InventoryData.json";
            InventoryDataManagement inventoryDataManagement = new InventoryDataManagement();
            myClass data = inventoryDataManagement.Read(path);
            for (int i = 0; i < data.riceList.Count; i++)
            {
                Console.WriteLine(data.riceList[i].Name);
                Console.WriteLine(data.riceList[i].Weight);
                Console.WriteLine(data.riceList[i].PricePerKg);
                int RicePrice = data.riceList[i].Weight * data.riceList[i].PricePerKg;
                Console.WriteLine("Total Price"+" "+RicePrice);

                for (int a = 0; a < data.pulseList.Count; a++)
                {
                    Console.WriteLine(data.pulseList[a].Name);
                    Console.WriteLine(data.pulseList[a].Weight);
                    Console.WriteLine(data.pulseList[a].PricePerKg);
                    int PulsePrice = data.pulseList[a].Weight * data.pulseList[a].PricePerKg;
                    Console.WriteLine("Total Price"+" "+PulsePrice);

                }

                for (int b = 0; b < data.wheatList.Count; b++)
                {
                    Console.WriteLine(data.wheatList[b].Name);
                    Console.WriteLine(data.wheatList[b].Weight);
                    Console.WriteLine(data.wheatList[b].PricePerKg);
                    int WheatPrice = data.wheatList[b].Weight * data.wheatList[b].PricePerKg;
                    Console.WriteLine("Total Price" + " " + WheatPrice);

                }
            }
        }
    }
}


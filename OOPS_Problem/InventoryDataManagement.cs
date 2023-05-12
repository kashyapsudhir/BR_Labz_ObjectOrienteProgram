using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPS_Problem
{
    public class InventoryDataManagement
    {
        public myClass Read(String Path) 
        {
            using(StreamReader file = new StreamReader(Path)) 
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<myClass>(json);
                }
                catch 
                (Exception e) 
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
    }
}

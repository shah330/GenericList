using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedant_Shoppping_List
{
    class VedantList
    {
        string[] list = new string[0];

        public void Add(string item)
        {
            string[] tempList = new string[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                tempList[i] = list[i];
            }
            tempList[tempList.Length - 1] = item;
            list = tempList;
        }

        public void Remove(string item)
        {
            if (list.Length >= 1)
            {
                string[] tempList = new string[list.Length];
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] != item)
                    {
                        tempList[i] = list[i];
                    }
                }
                list = tempList;
            }
        }

        public void Print()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("{0}", list[i]);
            }
        }
    }
}

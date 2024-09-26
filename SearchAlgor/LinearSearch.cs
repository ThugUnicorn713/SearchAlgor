using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgor
{
    internal class LinearSearch
    {
        public static int Perform(double searchValue, List<double> listToSearch)
        {
            for (int i = 0; i < listToSearch.Count; i++)
            { 
                if (listToSearch[i] == searchValue)
                {
                    return i;
                }
            }                

            return -1;
        }

        public static int Perform(string searchName, List<string> listToSearch)
        {
            for (int i = 0; i < listToSearch.Count; i++)
            {
                if (string.Compare(listToSearch[i], searchName) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

       
    }
}

    


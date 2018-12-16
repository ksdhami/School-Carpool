using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp1
{
    class pools
    {
        string[] get_pools;
        string[] give_pools;
        string[] my_pools;

        public pools(string email)
        {
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\pools.txt";

            int i = 1, j = 1, k = 1;
            string[] tmp_pools = new string[50];

            get_pools = new string [100];
            give_pools = new string [100];
            my_pools = new string [100];

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains(email))
                        {
                            my_pools[i] = line;
                            i++;
                        }
                        else if (line.Contains("GET"))
                        {
                            get_pools[j] = line;
                            j++;
                        }
                        else if (line.Contains("GIVE"))
                        {
                            give_pools[j] = line;
                            j++;
                        }

                        line = sr.ReadLine();
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Could not read pools file");
            }
        }

        public string[] getMyPools()
        {
            return this.my_pools;
        }
        public string[] getGetPools()
        {
            return this.get_pools;
        }
        public string[] getGivePools()
        {
            return this.give_pools;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp1
{
    class person
    {
        //Fields
        private string fname, lname, email, address, password, postal, uni;
        private string photo_path, bio, id_path, license_path, music, reviews;

        private string[] my_pools, get_pools, give_pools;
        public person()
        {
            fname = "";
            lname = "";
            email = "";
            address = "";
            password = "";
            postal = "";
            uni = "";

            bio = "";
            id_path = "";
            license_path = "";
            music = "";
            reviews = "";

            my_pools = new string [50];
            get_pools = new string[50];
            give_pools = new string[50];
        }

        public person(string[] fields)
        {
            if (fields.Length == 13)
            {
                email = fields[0];
                password = fields[1];
                fname = fields[2];
                lname = fields[3];
                address = fields[4];
                postal = fields[5];
                uni = fields[6];
                photo_path = fields[7];
                bio = fields[8];
                id_path = fields[9];
                license_path = fields[10];
                music = fields[11];
                reviews = fields[12];
            }
        }
        public person(string usr_email)
        {
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\dataBase.txt";
            bool userFound = false;
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line == usr_email)
                        {
                            email = line;
                            password = sr.ReadLine();
                            fname = sr.ReadLine();
                            lname = sr.ReadLine();
                            address = sr.ReadLine(); 
                            postal = sr.ReadLine();
                            uni = sr.ReadLine();
                            photo_path = sr.ReadLine();
                            bio = sr.ReadLine();
                            id_path = sr.ReadLine();
                            license_path = sr.ReadLine();
                            music = sr.ReadLine();
                            reviews = sr.ReadLine();

                            userFound = true;
                            break; 
                        }
                        
                        line = sr.ReadLine();
                    }                
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Could not read the file");
            }

            if(userFound == false)
            {
                fname = "";
                lname = "";
                email = "";
                address = "";
                password = "";
                postal = "";
                uni = "";
            }
        }
        public void SavePerson()
        {
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\dataBase.txt";

            using (StreamWriter outputFile = new StreamWriter(filepath, true))
            {

                outputFile.WriteLine(".");
                outputFile.WriteLine(this.email);
                outputFile.WriteLine(this.password);
                outputFile.WriteLine(this.fname);
                outputFile.WriteLine(this.lname);
                outputFile.WriteLine(this.address);
                outputFile.WriteLine(this.postal);
                outputFile.WriteLine(this.uni);
                outputFile.WriteLine(this.photo_path);
                outputFile.WriteLine(this.bio);
                outputFile.WriteLine(this.id_path);
                outputFile.WriteLine(this.license_path);
                outputFile.WriteLine(this.music);
                outputFile.WriteLine(this.reviews);
            }
        }
        public string[] Load_pools(string findThis)
        {
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\pools.txt";

            int i = 0, j = 0, k = 0;
            string[] tmp_pools = new string[50];
            
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains(findThis))
                        {
                            tmp_pools[i] = line;
                            i++;
                        }
                        
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Could not read pools file");
                tmp_pools[0] = "clark@theark.ca|GIVE|TIME|DEST|DATE|STATUS|POOLER_EMAIL";
                tmp_pools[1] = "clark@theark.ca|GIVE|TIME|DEST|DATE|STATUS|POOLER_EMAIL";
                tmp_pools[2] = "clark@theark.ca|GIVE|TIME|DEST|DATE|STATUS|POOLER_EMAIL";
                tmp_pools[3] = "clark@theark.ca|GIVE|TIME|DEST|DATE|STATUS|POOLER_EMAIL";
            }
            return tmp_pools;
        }
        public string[] Load_messages(string findThis) //I can't actually test this so I just used your Pools method with modifications
        {
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\test.txt";

            int i = 0;
            string[] tmp_messages = new string[50];
            string[] tmp_split = new string[6];
            string[] toSend;

            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line.Contains(findThis))
                        {
                            tmp_split = line.Split('|');

                            tmp_messages[Int32.Parse(tmp_split[2])] = line;
                            i++;
                        }

                        line = sr.ReadLine();
                    }
                    
                    toSend = new string[i];

                    for (int j = 0; j<i; j++)
                    {
                        toSend[j] = tmp_messages[j];
                    }
                }
            }
            catch (Exception ex)
            {
                toSend = new string[0];
                Console.WriteLine("Could not read msg file");
            }
            return toSend;
        }


        public void Set_MyPools(string[] tmp)
        {
            my_pools = tmp;
        }
        public void Add_Get_Pool(int i, string pool)
        {
            get_pools[i] = pool;
        }
        public void Add_Give_Pool(int i, string pool)
        {
            give_pools[i] = pool;
        }
        public string[] get_MyPools()
        {
            return this.my_pools;
        }
        public string[] get_GetPools()
        {
            return this.get_pools;
        }
        public string[] get_GivePools()
        {
            return this.give_pools;
        }
        public void AddPool(string pool)
        {
            string directory = Directory.GetCurrentDirectory();
            string filepath = directory + "\\pools.txt";

            using (StreamWriter outputFile = new StreamWriter(filepath, true))
            {
                outputFile.WriteLine(pool);
            }
        }
        public string getFirstName()
        {
            return this.fname;
        }
        public string getLastName()
        {
            return this.lname;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPassword()
        {
            return this.password;
        }
        public string getAddress()
        {
            return this.address;
        }
        public string getPostal()
        {
            return this.postal;
        }
        public string getUni()
        {
            return this.uni;
        }
        public string getPhotoPath()
        {
            return this.photo_path;
        }
        public string getBio()
        {
            return this.bio;
        }
        public string getReviews()
        {
            return this.reviews;
        }
        public string getMusic()
        {
            return this.music;
        }
    }
}

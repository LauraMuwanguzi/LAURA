using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_one
{
    class Program
    {


        public delegate void StudentDetails<L>(L inpi);


        private static string Name;
        private static int idd;
        private string studentAddress;

        public string getAddress()
        {
            return studentAddress;
        }

        public void setAddress(string SAddress)
        {
            studentAddress = SAddress;

        }



        public static void getSatudentName(string name)
        {
            Name = name;
            Console.WriteLine("Name: " + name);


        }

        public static void getStudentId(int id)
        {
            idd = id;
            Console.WriteLine("ID:" + id);
        }


        public void storeDick()
        {


            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, idd.ToString());
            dc.Add(2, Name);
            dc.Add(3, studentAddress);


            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> i in dc)
            {

                Console.WriteLine(" " + i.Value);
            }
        }





        static void Main(string[] args)
        {
            StudentDetails<string> home = new StudentDetails<string>(getSatudentName);
            home.Invoke("Sheba");
            StudentDetails<int> id = new StudentDetails<int>(getStudentId);
            id.Invoke(987);

            // invoking Student Details from Dictionary
            Program obj = new Program();
            obj.setAddress("London");
            obj.storeDick();

        }
    }
}

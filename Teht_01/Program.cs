using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create persons(Collection);
            Persons kaverit = new Persons();
            // Create few person objects
            Person person1 = new Person { Firstname = "Kirsi", Lastname = "Likkeli", SosialSecurityNumber = "07060-12243" };
            Person person2 = new Person { Firstname = "Hirsi", Lastname = "Sikkeli", SosialSecurityNumber = "0060-12243" };
            // Add person objects to Persons(myfriends)
            kaverit.AddPerson(person1);
            kaverit.AddPerson(person2);
            // Get one person
            Person ukki = kaverit.GetPerson(10);
            Console.WriteLine(ukki.ToString());
            if(ukki != null) {
                Console.WriteLine(ukki.ToString());
            }else {
                Console.WriteLine("NO position");
            }
            // Print collection
            kaverit.PrintData();
            Console.WriteLine();
            Person person5 = kaverit.FindPerson("0060-12243");
            if(person5 !=null) {
                Console.WriteLine(person5.ToString());
            }
            else {
                Console.WriteLine("Cant find");
            }
        }
    }
}

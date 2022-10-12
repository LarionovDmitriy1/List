using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Contact
    {
       private string _number;
       private string _name;
       private string _sername;

       public Contact(string number, string name, string sername)
        {
            _name = name;
            _sername = sername;
            _number = number;
        }
        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Имя - {_name}");
            Console.WriteLine($"Фамилия - {_sername}"); 
            Console.WriteLine($"Номер - {_number}");
            Console.WriteLine();
        }
        public string GetNumber()
        {

            return _number;
        }
        public string GetName()
        {
            return _name;
        }
        public void DeleteContact()
        {
            _name = null;
            _sername = null;
            _number = null;
           
        }
      


    }
}

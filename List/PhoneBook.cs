using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class PhoneBook
    {
        List<Contact> _contacts = new List<Contact>();
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DeleteContact(PhoneBook book)
        {
            Console.WriteLine("Введите номер, который вы хотите удалить");
            string a = Console.ReadLine();
            bool result = false;
            foreach (var check in _contacts)
            {
                if (a == check.GetNumber())
                {

                    result = _contacts.Remove(check);
                   
                    return;
                    
                }
                 

            }
            if (result == true)
            {
                Console.WriteLine("Контакт был удален");
            }
            else
            {
                Console.WriteLine("Такого контакта нет");
            }
        }

        public void ContactList()
        {
            if (_contacts is null || _contacts.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Список контактов пуст");
            }

            else foreach (var user in _contacts)
                {
                    user.GetInfo();
                }
        }

        public void CheckContact()
        {
            Console.WriteLine("Введите номер, который вы хотите проверить");
            string a = Console.ReadLine();


            foreach (var check in _contacts)
            {
                if (a == check.GetNumber())
                {
                    Console.WriteLine($"Текущий контакт есть в списке под именем {check.GetName()}");
                }
            }


        }

        public void DeleteAllContact()
        {
            _contacts = null;
            Console.WriteLine();
            Console.WriteLine("Все контакты удалены");
        }
    }
}

using List;
List<Contact> contacts = new List<Contact>();
PhoneBook pBook = new PhoneBook();
while (true)
{
    void Menu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Добавить контакт");
        Console.WriteLine("2. Удалить контакт");
        Console.WriteLine("3. Удалить все контакты");
        Console.WriteLine("4. Просмотреть все контакты");
        Console.WriteLine("5. Проверить контакт");
        Console.WriteLine();
        string select = Console.ReadLine();
        int select1 = int.Parse(select);
        if (select1 == 1)
        {
            Console.WriteLine(  );
            Console.WriteLine("Введите имя");
            string a = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите фамилию");
            string b = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Введите номер");
            string c = Console.ReadLine();
            Contact contact = new Contact(c, a, b);
            pBook.AddContact(contact);
        }
        else if (select1 == 2)
        {
            PhoneBook book = new PhoneBook();
            pBook.DeleteContact(book);
        }
        else if (select1 == 3)
        {
            pBook.DeleteAllContact();
        }
        else if (select1 == 4)
        {
            pBook.ContactList();
        }
        else if (select1 == 5)
        {
            pBook.CheckContact();
        }
    }
    Menu();
}
using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,enum,float,boolean value types
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;

            //Console.WriteLine("Sayı 1 : " + sayi1);

            //array,class,inteface ... reference types
            //int[] sayilar1 = new int[] { 1, 2, 3 };

            //int[] sayilar2 = new int[] { 100, 200, 300 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar1[0] : " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Yaşar";
            person2 = person1;
            person1.FirstName = "Elif";
            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Azra";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;

            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonelManager personelManager = new PersonelManager();
            personelManager.Add(person3);
            personelManager.Add(customer);
            personelManager.Add(person2);
            personelManager.Add(person1);
            personelManager.Add(employee);

        }
    }

    //base class : Person 
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonelManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

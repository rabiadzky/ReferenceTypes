using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Rabia";
            person2 = person1;//person1 in adresi person2 nin adresine atandı.
            person1.FirstName = "Arda";
            //Console.WriteLine(person2.FirstName);//Arda çıkar

            Customer customer = new Customer();
            customer.FirstName = "Emir";
            customer.CreditCardName = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Baki";

            Person person3 = new Person();
            customer.FirstName = "Abdullah";
            //Console.WriteLine(((Customer)person3).CreditCardName); ?

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);//baki
            personManager.Add(customer);//abdullah            

        }
    }
    //Person, customer ve employee adreslerini tutabiliyor.
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class : Person
    class Customer:Person
    {
        public string CreditCardName { get; set; }
    }
    class Employee:Person
    {
        public  int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

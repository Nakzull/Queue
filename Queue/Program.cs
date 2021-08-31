using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Customer> customers = new Queue<Customer>();
            ReturnPoint:
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("\n                                                H1 Queue Operations Menu");
            Console.WriteLine("\n=======================================================================================================================");
            Console.WriteLine("\n1. Add person");
            Console.WriteLine("2. Remove person first in line");
            Console.WriteLine("3. Show nunmer of people in queue");
            Console.WriteLine("4. Show first and last person");
            Console.WriteLine("5. Find a person");
            Console.WriteLine("6. Print all people in queue");
            Console.WriteLine("7. Exit");
            Console.WriteLine("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());            
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Name of the person you wish to add to the queue: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Age of the person you wish to add to the queue: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        customers.Enqueue(new Customer(name, age));
                        Console.WriteLine(name + " age " + age + " has been added to the queue");
                        goto ReturnPoint;
                        
                    case 2:
                        Customer firstToLeave = customers.Dequeue();
                        Console.WriteLine(firstToLeave + " has left the queue\nQueue after that person left:");
                        goto ReturnPoint;
                    case 3:
                        Console.WriteLine("Number of people in queue: " + customers.Count);
                        goto ReturnPoint;
                    case 4:
                        Customer[] lastCustomer = customers.ToArray();
                        var lastCustomerData = lastCustomer[lastCustomer.Length - 1];
                        string firstName = customers.Peek().Name;
                        Console.WriteLine("Person in front of queue {0}" + "\nPerson in the back of the queue {1}", firstName, lastCustomerData.Name);
                        goto ReturnPoint;
                    case 5:
                        Console.WriteLine("Name of the person you are looking for: ");
                        string customerLookupName = Console.ReadLine();
                        Console.WriteLine("Age of the person you at looking for: ");
                        int customerLookupAge = Convert.ToInt32(Console.ReadLine());
                        Customer customerLookupList = new Customer(customerLookupName, customerLookupAge);
                        if (customers.Contains(customerLookupList))
                        {
                            Console.WriteLine("The person you are looking for is in the queue");
                        }
                        else
                            Console.WriteLine("The person you are looking for isn't in the queue");
                        goto ReturnPoint;
                    case 6:
                        foreach (var items in customers)
                            Console.WriteLine("Name: " +items.Name + " Age: " + items.Age);
                        goto ReturnPoint;
                    case 7:
                        goto ReturnPoint;
                    default:
                        Console.WriteLine("Please select between 1-7");
                        goto ReturnPoint;
                }
            }
        }
    }
}

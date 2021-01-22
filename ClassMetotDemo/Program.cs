using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Halil";
            customer1.CustomerSurname = "Kabak";
            customer1.CustomerId = 12345678905;
            customer1.CustomerPhone = "0531 056 78 89";
            customer1.CustomerAddress = "Cevatpaşa Sokağı Bülbül Mahallesi No:5  İSTANBUL";
            customer1.AccountNumber = 4446;
            customer1.CustomerNumber = 55568987;
            customer1.CreditLimit = 3200;

            Customer customer2 = new Customer();
            customer2.CustomerName = "İbrahim";
            customer2.CustomerSurname = "Menteş";
            customer2.CustomerId = 49632875123;
            customer2.CustomerPhone = "0545 654 98 00";
            customer2.CustomerAddress = "Manolya caddesi Viran sokak No:125/8  KARAMAN";
            customer2.AccountNumber = 3500;
            customer2.CustomerNumber = 14658930;
            customer2.CreditLimit = 5000;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Leyla";
            customer3.CustomerSurname = "Solmaz";
            customer3.CustomerId = 56398741036;
            customer3.CustomerPhone = "0555 106 89 74";
            customer3.CustomerAddress = "Şehremini Mahallesi Yolgeçmez Sokak No:2563  ANTALYA";
            customer3.AccountNumber = 8900;
            customer3.CustomerNumber = 90036463;
            customer3.CreditLimit = 10000;

           
            Customer[] customers = new Customer[] {customer1,customer2,customer3};
            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerList(customers);

            






        }
    }
}

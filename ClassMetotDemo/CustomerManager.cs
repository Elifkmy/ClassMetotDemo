using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müşteri T.C. No: " + customer.CustomerId + "\n" + "Müşteri Numarası: " + customer.CustomerNumber + "\n" + "Müşteri Adı: " + customer.CustomerName + "\n" +
               "Müşteri Soyadı: " + customer.CustomerSurname + "\n" + "Müşteri Telefon: " + customer.CustomerPhone + "\n" + "Müşteri Adres: " + customer.CustomerAddress + "\n" +
               "Müşteri Hesap Numarası: " + customer.AccountNumber + "\n" + "Kredi Limiti: " + customer.CreditLimit + " TL \n\n");

        }

        public void CustomerDelete(Customer customer)
        {
            uint Customer_number;
            Console.WriteLine("Müşteri Hesabını silmek için Müşteri Numarasını giriniz: ");
            Customer_number =Convert.ToUInt32(Console.ReadLine());
           
            if (Customer_number==customer.CustomerNumber)
            {
                Console.WriteLine("Girmiş olduğunuz müşteri numarasına kayıtlı kullanıcının Hesap Bilgileri silinmiştir.\n\n\n ");
            }
            else
            {
                Console.WriteLine("Müşteri numarasını yanlış girdiniz. \n\n");
                
            }
            
            
        }

        public void CustomerList(Customer[] customer)
        {
            Console.WriteLine("-------Müşteri Listesi------\n");
            foreach (var customers in customer)
            {
                Console.WriteLine("Müşteri T.C. No: " + customers.CustomerId + "\n" + "Müşteri Numarası: " + customers.CustomerNumber + "\n" + "Müşteri Adı: " + customers.CustomerName + "\n" +
                              "Müşteri Soyadı: " + customers.CustomerSurname + "\n" + "Müşteri Telefon: " + customers.CustomerPhone + "\n" + "Müşteri Adres: " + customers.CustomerAddress + "\n" +
                              "Müşteri Hesap Numarası: " + customers.AccountNumber + "\n" + "Kredi Limiti: " + customers.CreditLimit + " TL \n\n");
            }


        }
    }
}

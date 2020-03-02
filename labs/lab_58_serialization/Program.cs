using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace lab_58_serialization
{
    class Program
    {

        // lab
        // create list of 2 customers
        // convert (serialize) to JSON and print JSON on console
        // Newtonsoft.Json

        // Get data 
        // Use HttpClient to get Json as string from 
        // https://raw.githubusercontent.com/philanderson888/data/master/customers.json
        // deserialize to List<Customer> and print the list to Console



        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>();

            var customer01 = new Customer()
            {
                CustomerID = 1,
                CustomerName = "Fred",
                Address = "2 North Street"
            };
            customers.Add(customer01);

            var customersAsJson = JsonConvert.SerializeObject(customers);
            Console.WriteLine($"List of customers as a JSON string is {customersAsJson}");

            // get data back

            var url = "https://raw.githubusercontent.com/philanderson888/data/master/customers.json";
            var httpclient = new HttpClient();
            var jsonFromAPI = httpclient.GetStringAsync(url).Result;
            var customersFromAPI = JsonConvert.DeserializeObject<List<Customer>>(jsonFromAPI);
            customersFromAPI.ForEach(c => Console.WriteLine($"{c.CustomerID,-10},{c.CustomerName,-20}" +
                $"{c.Address}"));
        }
    }


    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string Address { get; set; }
    }

}

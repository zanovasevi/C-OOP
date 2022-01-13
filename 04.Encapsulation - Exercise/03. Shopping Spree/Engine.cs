using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Engine
    {
        public void Run()
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                string[] peopleInput = Console.ReadLine().Split(";");


                foreach (var human in peopleInput)
                {
                    string[] personInfo = human.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    string personName = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);

                    Person person = new Person(personName, money);
                    persons.Add(person);
                }


                string[] productsInput = Console.ReadLine().Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);


                foreach (var prod in productsInput)
                {
                    string[] productInfo = prod.Split("=");
                    string productName = productInfo[0];
                    decimal price = decimal.Parse(productInfo[1]);

                    Product product = new Product(productName, price);
                    products.Add(product);
                }

                var input = Console.ReadLine();

                while (input != "END")
                {
                    string[] splitted = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string buyer = splitted[0];
                    string productName = splitted[1];

                    var person = persons.FirstOrDefault(p => p.Name == buyer);
                    var shopProduct = products.FirstOrDefault(p => p.Name == productName);

                    bool result = person.BuyProduct(shopProduct);

                    if (result)
                    {
                        Console.WriteLine($"{person.Name} bought {shopProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {shopProduct.Name}");
                    }


                    input = Console.ReadLine();
                }


                foreach (var person in persons)
                {
                    if (person.Bag.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        var collection = new List<string>();

                        foreach (var prod in person.Bag)
                        {
                            collection.Add(prod.Name);
                        }

                        Console.WriteLine($"{person.Name} - {string.Join(", ", collection)}");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

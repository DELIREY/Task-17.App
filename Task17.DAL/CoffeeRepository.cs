using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using Task17.Model;

namespace Task17.DAL
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private static List<Coffee> coffees;
        public CoffeeRepository()
        {

        }
        public Coffee GetACoffee()
        {
            if (coffees == null)
                LoadCoffees();
            return coffees.FirstOrDefault();
        }
        public List<Coffee> GetCoffees()
        {
            if (coffees == null)
                LoadCoffees();
            return coffees;
        }
        public Coffee GetCoffeeById(int id)
        {
            if (coffees == null)
                LoadCoffees();

            return coffees.Where(c => c.CoffeeId == id).FirstOrDefault();
        }
        public void DeleteCoffee(Coffee coffee)
        {
            coffees.Remove(coffee);
        }
        public void UpdateCoffee(Coffee coffee)
        {
            Coffee coffeeToUpdate = coffees.Where(c => c.CoffeeId == coffee.CoffeeId).FirstOrDefault();
        }
        private void LoadCoffees()
        {
            coffees = new List<Coffee>()
            {
                new Coffee ()
                {
                    CoffeeId = 1,
            CoffeeName = "Домашний латте",
            Description = "Просто лучший латте в мире, с небольшим количеством орехового сиропа!",
            ImageId = 1,
            AmountInStock = 10,
            InStock = true,
            FirstAddedToStockDate = new DateTime(2022,1,3),
            OriginCountry = Country.Эфиопия,
            Price = 150
                },
                new Coffee ()
                {
                    CoffeeId = 2,
                    CoffeeName = "Эспрессо",
                    Description = "Эспрессо - это крепкий черный кофе, при готовленный путем пропускания пара",
                    ImageId = 2,
                    InStock = true,
                    AmountInStock= 100,
                    FirstAddedToStockDate = new DateTime(2022,10,3),
                    OriginCountry = Country.Колумбия,
                    Price = 170

                },
                new Coffee ()
                {
                    CoffeeId = 3,
                    CoffeeName = "Капучино",
                    Description = "Настоящий капучино - это сочетание равных частей эспрессо и парного молока",
                    ImageId = 3,
                    InStock = true,
                    AmountInStock= 0,
                    FirstAddedToStockDate = new DateTime(2022,5,5),
                    OriginCountry = Country.Эквадор,
                    Price = 180
                },
                new Coffee ()
                {
                    CoffeeId = 4,
                    CoffeeName = "Американо",
                    Description = "Американо - это одна порция эспрессо, добавленная в чашку горячей воды",
                    ImageId = 4,
                    InStock = true,
                    AmountInStock= 200,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.Индия,
                    Price = 160
                },
                new Coffee ()
                {
                    CoffeeId = 5,
                    CoffeeName = "Кофе Латте",
                    Description = "Кофе Латте -   это одна порция эспрессо на три части парного молока",
                    ImageId = 5,
                    InStock = true,
                    AmountInStock= 0,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.Индия,
                    Price = 190
                },
                new Coffee ()
                {
                    CoffeeId = 6,
                    CoffeeName = "Кофе с молоком",
                    Description = "Этот традиционный французский напиток похож на кофе латте",
                    ImageId = 6,
                    InStock = false,
                    AmountInStock= 8,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.Индия,
                    Price = 200

                },
                new Coffee ()
                {
                    CoffeeId = 7,
                    CoffeeName = "Кофе Мокко",
                    Description = "Это капучино или кофе латте с добавлением школадного сиропа или порошка",
                    ImageId = 7,
                    InStock = true,
                    AmountInStock= 1000,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.Эфиопия,
                    Price = 130
                },
                new Coffee ()
                {
                    CoffeeId = 8,
                    CoffeeName = "Кофе с молоком",
                    Description = "Это еще один вариант, который готовится разными способами в разных кофейнях",
                    ImageId = 8,
                    InStock = true,
                    AmountInStock= 200,
                    FirstAddedToStockDate = new DateTime(2022,9,9),
                    OriginCountry = Country.Гондурас,
                    Price = 170
                }

            };
        }

    }
}

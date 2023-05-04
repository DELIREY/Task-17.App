using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17.App.Services
{
    public class CoffeeDataService : ICoffeeDataService

    {
        ICoffeeRepository _repository;
        public CoffeeDataService(ICoffeeDataService repository)
        {
            _repository = repository;
        }
        public CoffeeDataService GetCoffeeDetail(int coffeeId)
        {
            return _repository.GetCoffeeDetail(coffeeId); 
        }
        public List<Coffee> GetAllCoffees() 
        {
            return _repository.GetCoffees();
        }
        public void DeleteCoffee(CoffeeDataService coffee)
        {
            _repository.DeleteCoffee(coffee);
        }
    }
}

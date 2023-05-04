using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_17.App.Services
{
    public interface ICoffeeDataService
    {
        void DeleteCoffee(ICoffeeDataService coffee);
        List<Coffee> GetAllCoffees();
        ICoffeeDataService GetCoffeeDetail(int coffeeId);
        void UpdateCoffee(ICoffeeDataService coffee);
    }
}

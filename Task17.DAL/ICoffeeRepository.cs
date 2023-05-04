using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task17.Model;

namespace Task17.DAL

{
    
    public interface ICoffeeRepository
    {
        void DeleteCoffee(Coffee coffee);
        Coffee GetACoffee();
        Coffee GetCoffeeById(int id);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
    }

}

using FruitShop.AppLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.AppLogic.Data
{
    static class FruitData
    {
        public static string ConnectionString { private get;  set; }

        private static List<Fruit> _fruits;
        public static List<Fruit> Fruits
        {
            get { return _fruits; }
        }


        public static Fruit CreateFruit(string name, string color, string season)
        {
            //TODO: Create a unique id for the fruit using the GetMaxFruitId function
            //TODO: Create a fruit record in the database with the given parameters (use SqlParameters!)
            //TODO: Return a new fruit object
            throw new NotImplementedException();
        }

        private static int GetMaxFruitId()
        {
            throw new NotImplementedException();
        }

        public static bool DeleteFruit(int id)
        {
            //TODO: Delete the fruit with the given id from the database
            //TODO: Remove the fruit from the _fruits list
            throw new NotImplementedException();
        }

        public static void LoadAllFruits()
        {
            //TODO: Load all fruits from the database
            //TODO: Add all records as a Fruit object to the _fruits list
            throw new NotImplementedException();
        }
    }
}

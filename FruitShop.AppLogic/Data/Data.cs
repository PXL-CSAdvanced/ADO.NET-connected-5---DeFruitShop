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
    static class Data
    {
        public static string ConnectionString { private get;  set; }

        private static List<Fruit> _fruits;
        public static List<Fruit> Fruits
        {
            get { return _fruits; }
        }


        public static int CreateFruit(Fruit fruit)
        {
            throw new NotImplementedException();
        }

        private static int GetMaxFruitId()
        {
            throw new NotImplementedException();
        }

        public static int DeleteFruit(int id)
        {
            throw new NotImplementedException();
        }

        public static List<Fruit> GetAllFruit()
        {
            throw new NotImplementedException();
        }
    }
}

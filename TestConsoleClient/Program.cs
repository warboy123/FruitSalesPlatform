using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Common;
using DTO;
using IService;
using DataSeeds;
namespace TestConsoleClient
{
    public class Program
    {
        public static IFruitsService _fruit;
       
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            Assembly[] assemblyList = Depandency.LoadAssembly();
            Depandency.RegisterAssembly(ref container, assemblyList);
            CreateDataMapper.InitMapper();
            _fruit = Depandency.GetService<IFruitsService>();
            FruitsSeed fseed = new FruitsSeed();
            FruitsDTO fruit = new FruitsDTO { FruitName="芒果", PlaceID=0 };
            _fruit.Add(fruit);
        }
    }
}

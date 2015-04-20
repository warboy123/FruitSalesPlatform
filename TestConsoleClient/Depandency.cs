using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleClient
{
    public class Depandency
    {
         private static IUnityContainer _container;
         private static IUnityContainer _childContainer;
         protected static IUnityContainer ChildContainer
         {
             get
             {
                 var childContainer = _childContainer;

                 if (childContainer == null)
                 {
                     _childContainer = childContainer = _container.CreateChildContainer();
                 }

                 return childContainer;
             }
         }
        
         private bool IsRegistered(Type typeToCheck)
         {
             var isRegistered = true;

             if (typeToCheck.IsInterface || typeToCheck.IsAbstract)
             {
                 isRegistered = ChildContainer.IsRegistered(typeToCheck);

                 if (!isRegistered && typeToCheck.IsGenericType)
                 {
                     var openGenericType = typeToCheck.GetGenericTypeDefinition();

                     isRegistered = ChildContainer.IsRegistered(openGenericType);
                 }
             }

             return isRegistered;
         }
        public static T GetService<T>()
        { 
            return  ChildContainer.Resolve<T>();
        }
        public static Assembly[] LoadAssembly()
        {
            IList<Assembly> assList = new List<Assembly>();

            assList.Add(Assembly.Load("Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assList.Add(Assembly.Load("IService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assList.Add(Assembly.Load("DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            assList.Add(Assembly.Load("IDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
            return assList.ToArray();
        }
        public static void RegisterAssembly(ref UnityContainer container, Assembly[] currentAssembly)
        {
            Dictionary<string, Type> dictInterface = new Dictionary<string, Type>();
            Dictionary<string, Type> dictDAL = new Dictionary<string, Type>();

            //string dalSuffix = ".DAL";
            //string interfaceSuffix = ".IDAL";
            foreach (Assembly assembly in currentAssembly)
            {
                //对比程序集里面的接口和具体的接口实现类，把它们分别放到不同的字典集合里
                foreach (Type objType in assembly.GetTypes())
                {
                    string defaultNamespace = objType.Namespace;
                    if (objType.IsInterface)
                    {
                        if (!dictInterface.ContainsKey(objType.FullName))
                        {
                            dictInterface.Add(objType.FullName, objType);
                        }
                    }
                    else
                    {
                        if (!dictDAL.ContainsKey(objType.FullName))
                        {
                            dictDAL.Add(objType.FullName, objType);
                        }
                    }
                }
            }

            //根据注册的接口和接口实现集合，使用IOC容器进行注册
            foreach (string key in dictInterface.Keys)
            {
                Type interfaceType = dictInterface[key];

                foreach (string dalKey in dictDAL.Keys)
                {
                    Type dalType = dictDAL[dalKey];
                    TypeFilter myFilter = new TypeFilter(MyInterfaceFilter);
                    Type[] ts = dalType.FindInterfaces(myFilter, interfaceType);
                    if (interfaceType.IsAssignableFrom(dalType))//判断DAL是否实现了某接口
                    {
                        container.RegisterType(interfaceType, dalType);
                    }
                }
            }
            _container = container;
        }
        private static bool MyInterfaceFilter(Type typeObj, Object criteriaObj)
        {
            if (typeObj.ToString() == criteriaObj.ToString())
                return true;
            else
                return false;
        }
    }
}

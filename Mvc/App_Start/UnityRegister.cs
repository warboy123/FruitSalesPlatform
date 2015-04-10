using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MVCWeb.App_Start
{
    public class UnityRegister
    {
        /// <summary>
        /// 使用Unity自动加载对应的IDAL接口的实现（DAL层）
        /// </summary>
        /// <param name="container"></param>
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
                    if (objType.IsInterface )
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
                    if (interfaceType.IsAssignableFrom(dalType) )//判断DAL是否实现了某接口
                    {
                        container.RegisterType(interfaceType, dalType);
                    }
                }
            }
        }
        public static void RegisterAssembly(ref UnityContainer container, Assembly currentAssembly)
        {
            Dictionary<string, Type> dictInterface = new Dictionary<string, Type>();
            Dictionary<string, Type> dictDAL = new Dictionary<string, Type>();

            //string dalSuffix = ".DAL";
            //string interfaceSuffix = ".IDAL";
           
                //对比程序集里面的接口和具体的接口实现类，把它们分别放到不同的字典集合里
            foreach (Type objType in currentAssembly.GetTypes())
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
        }
        public static bool MyInterfaceFilter(Type typeObj, Object criteriaObj)
        {
            if (typeObj.ToString() == criteriaObj.ToString())
                return true;
            else
                return false;
        }

    }
}

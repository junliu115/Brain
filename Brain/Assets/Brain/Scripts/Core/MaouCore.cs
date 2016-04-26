using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Maou.Core
{
    public class MaouCore
    {
		static private Dictionary<Type,object> controllerDict = new Dictionary<Type, object>();

		static public T GetController<T>()
        {
            Type controllerType = typeof(T);
            if (!controllerDict.ContainsKey(controllerType))
            {
                controllerDict [controllerType] = Activator.CreateInstance(controllerType);
                if (!(controllerDict [controllerType] is MaouController))
                {
                    throw new Exception("'" + controllerType.Name + "' does not extend class 'MaouController'");
                }
            }
            return (T)controllerDict [controllerType];
        }
                
        static public MaouController GetController(Type controllerType)
        {
            if (!controllerDict.ContainsKey(controllerType))
            {
                controllerDict [controllerType] = Activator.CreateInstance(controllerType);
                if (!(controllerDict [controllerType] is MaouController))
                {
                    throw new Exception("'" + controllerType.Name + "' does not extend class 'MaouController'");
                }
            }
            return (MaouController)controllerDict [controllerType];
        }
        
        static public void Call(MaouCommand command)
        {
            DirectCall(command);
        }
        static public void DirectCall(MaouCommand command)
        {
            MaouController controller = MaouCore.GetController(command.GetController());
            MethodInfo methodInfo = controller.GetType().GetMethod("On"+command.GetType().Name);//拿到函数的句柄
            if(methodInfo != null)
            {
                methodInfo.Invoke(controller,new object[]{command});//调用函数的方法
            }
        }
        
        static public void Reset()
        {           
            foreach(MaouController controller in controllerDict.Values)
            {
                controller.OnDestroy();
            }
            controllerDict.Clear();
        }
    }
}

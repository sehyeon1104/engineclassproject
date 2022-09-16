using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class UI_Base : MonoBehaviour
{
    protected Dictionary<Type, UnityEngine.Object[]> _objects = new Dictionary<Type, UnityEngine.Object[]>();

    protected void Bind<T>(Type type) where T : UnityEngine.Object
    {
        string[] names= Enum.GetNames(type);
        UnityEngine.Object[] objects =new UnityEngine.Object[names.Length];
        _objects.Add(typeof(T),objects);

        for(int i = 0; i< names.Length; i++)
        {
            objects[i]=Util.Findchild<T>(gameObject,names[i],true);
            if (objects[i] == null)
                print($"Failed to bind {names[i]}");
        }

    }
}

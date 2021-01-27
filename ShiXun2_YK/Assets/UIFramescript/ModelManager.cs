using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ModelManager : SingLeton<ModelManager>
{
    Dictionary<Type, Modelbase> modic = new Dictionary<Type, Modelbase>();
    public void LoadAll()
    {
        Load(new Modelbase());
    }

    private void Load(Modelbase temp)
    {
        if (!modic.ContainsValue(temp))
        {
            temp.Load();
            modic.Add(temp.GetType(), temp);
        }
       
    }
    public Modelbase GetType<T>()where T : Modelbase
    {
        Type type = typeof(T);
        Modelbase temp;
        if(modic.TryGetValue(type,out temp))
        {
            return temp as T;
        }
        else { return null; }
    }
}

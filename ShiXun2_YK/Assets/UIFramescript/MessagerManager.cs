using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MessagerManager : SingLeton<MessagerManager>
{
    Dictionary<string, Action<object>> medic = new Dictionary<string, Action<object>>();

    public void Resgion(string str,Action<object> action)
    {
        if (!medic.ContainsKey(str))
        {
            medic.Add(str, action);
        }
    }
    public void Lend(string str,object info)
    {
        if (medic.ContainsKey(str))
        {
            medic[str](info);
        }
    }
    public void Remove(string str, Action<object> action)
    {
        if (medic.ContainsKey(str))
        {
            medic[str] -= action;
            if (medic[str] == null)
            {
                medic.Remove(str);
            }
        }
    }

}

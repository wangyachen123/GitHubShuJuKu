using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingLeton<T>where T:new()
{
    private static T intance;
    public static T Intance
    {
       
        get
        {
            if (intance == null)
            {
                intance = new T();
            }
            return intance;
        }

    }
}

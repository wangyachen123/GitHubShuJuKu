using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum RectType
{
    item,
    panel
}

public class ResManager :SingLeton<ResManager>
{
    Dictionary<string, Object> resdic = new Dictionary<string, Object>();

    public T Res<T>(RectType type,string path)where T : Object
    {
        string newpath = type.ToString() + "/" + path;
        return GetT<T>(newpath);
    }

    private T GetT<T>(string path)where T : Object
    {
        Object temp;
        if(resdic.TryGetValue(path,out temp))
        {
            return temp as T;
        }
        else
        {
            temp = Resources.Load<T>(path);
            resdic.Add(path, temp);
            return Resources.Load<T>(path);
        }
    }

    public void Remove()
    {
        foreach (var item in resdic.Values)
        {
            Resources.UnloadAsset(item);
        }
        resdic.Clear();
        System.GC.Collect();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configbase
{
    public string name;
}
public class Configdata : Configbase
{

}

public class ConfigType<T> where T : Configbase
{
    public List<T> datalist = new List<T>();
}



public class ConfigManager : SingLeton<ConfigManager>
{
    public ConfigType<Configdata> datalist;
    private ConfigType<Configdata> Datalist
    {
        get
        {
            return datalist;
        }

    }


    public void ReadAll()
    {
        Readinfo();
    }

    public void Readinfo()
    {

    }
}

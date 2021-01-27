using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : SingLeton<UIManager>
{
    Dictionary<Panelname, UIbase> bigdic = new Dictionary<Panelname, UIbase>();
    Dictionary<Panelname, UIbase> smalldic = new Dictionary<Panelname, UIbase>();

    public Transform panelpos;

    public UIManager()
    {
        panelpos = GameObject.Find("Canvas/panelpos").transform;
    }

    public void OpenUI(Panelname name)
    {
        UIbase temp=Load(name);
        switch (temp.typeandPos.panelType)
        {
            case PanelType.normal:
                Open(name);
                break;
            default:
                break;
        }
        switch (temp.typeandPos.panelPos)
        {
            case PanelPos.panelpos:
                temp.gameObject.transform.SetParent(panelpos, false);
                break;
            default:
                break;
        }
    }

    public void Open(Panelname name)
    {
        UIbase temp;
        if(!smalldic.TryGetValue(name,out temp))
        {
            temp = Load(name);
            smalldic.Add(name, temp);
        }
        temp.Show();
    }

    public void CloseUI(Panelname name)
    {
        UIbase temp;
        if(smalldic.TryGetValue(name,out temp))
        {
            smalldic.Remove(name);
        }
        temp.close();
    }
         

    public UIbase Load(Panelname name)
    {
        UIbase temp;
        if(bigdic.TryGetValue(name,out temp))
        {
            return temp;
        }
        else
        {
            GameObject objpdf = ResManager.Intance.Res<GameObject>(RectType.panel, name.ToString());
            if (objpdf == null)
            {
                Debug.LogError("预设体不存在！");
            }
            else
            {
                GameObject obj = GameObject.Instantiate(objpdf);
                temp = obj.GetComponent<UIbase>();
                if (temp == null)
                {
                    Debug.LogError("没挂脚本！");
                }
                else
                {
                    temp.Init();
                    bigdic.Add(name, temp);
                }

            }
            return temp;
        }

    }



}

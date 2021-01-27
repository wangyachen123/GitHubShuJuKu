using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Number_1 : MonoBehaviour
{
    public InputField str;
    public Text show;
    public Button change;
    void Start()
    {
        change.onClick.AddListener(Change);
    }
    string st =" ";
    List<string> strlist = new List<string>();
    List<List<string>> strls = new List<List<string>>();
    private void Change()
    {
        if (str.text!= "")
        {
            string showstr = "";
            string[] strs = str.text.Split(',');
            for (int i = 0; i < strs.Length; i++)
            {
                Debug.LogError(strs[i]);
                char[] chars = strs[i].ToCharArray();
                int num = chars.Length;
                for (int j = chars.Length-1; j>=0 ; j--)
                {
                    
                    if (chars[j]==' '||j==0)
                    {

                        st = "";
                        for (int k = j; k < num; k++)
                        {
                            st = st + chars[k];
                        }

                        num= j;
                        strlist.Add(st);
                        //Debug.LogError(st);
                    }

                }
                for (int j = 0; j < strlist.Count; j++)
                {
                    
                    
                    showstr += strlist[j];
                    showstr += " ";
                }
                strlist.Clear();
                showstr += ",";
            }
           
           
            show.text = showstr;
        }
    }
}

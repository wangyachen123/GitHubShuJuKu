using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIbase : MonoBehaviour
{
    public TypeandPos typeandPos = new TypeandPos();
    public virtual void Init()
    {

    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void close()
    {
        gameObject.SetActive(false);
    }


}

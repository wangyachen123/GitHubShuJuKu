using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Strtdt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag=="player")
        {
            Debug.LogError("开始读进度条！");
        }
    }
}

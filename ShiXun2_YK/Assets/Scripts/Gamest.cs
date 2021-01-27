using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamest : MonoBehaviour
{
    public GameObject player;
    public PlayerDate playdate;
    void Start()
    {
        playdate = Playerinfo.Intance.playerdate;
        Createplayer();
    }
    public void Createplayer()
    {
        player = GameObject.Instantiate(Resources.Load<GameObject>(playdate.nam));
        player.AddComponent<Player>();
        Playerinfo.Intance.player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

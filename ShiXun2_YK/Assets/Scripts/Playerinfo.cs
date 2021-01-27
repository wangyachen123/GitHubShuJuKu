using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinfo : SingLeton<Playerinfo>
{
   public List<PlayerDate> playerlist = new List<PlayerDate>();
    public PlayerDate playerdate;
    public GameObject player;
}
public class PlayerDate
{
    public int PH;
    public int SP;
    public int JD;
    public string nam;
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class SelectPlayer : MonoBehaviour
{
    public Button bt1, bt2, bt3, toagme;
    public GameObject player1, player2, player3;
    void Start()
    {
        Createtype();
        bt1.onClick.AddListener(Bt1);
        bt2.onClick.AddListener(Bt2);
        bt3.onClick.AddListener(Bt3);
        toagme.onClick.AddListener(ToGame);
    }

    private void ToGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void Bt1()
    {
        Showplayer(player1);
        Playerinfo.Intance.playerdate = Playerinfo.Intance.playerlist[0];
    }

    private void Bt2()
    {
        Showplayer(player2);
        Playerinfo.Intance.playerdate = Playerinfo.Intance.playerlist[1];
    }

    private void Bt3()
    {
        Showplayer(player3);
        Playerinfo.Intance.playerdate = Playerinfo.Intance.playerlist[2];
    }

    private void Createtype()
    {
        player1 = GameObject.Instantiate(Resources.Load<GameObject>("player1"));
        player2 = GameObject.Instantiate(Resources.Load<GameObject>("player2"));
        player3 = GameObject.Instantiate(Resources.Load<GameObject>("player3"));
        player1.transform.position = new Vector3(0, 0, 0);
        player1.transform.rotation = new Quaternion(0, 180, 0, 0);
        player2.transform.position = new Vector3(0, 0, 0);
        player2.transform.rotation = new Quaternion(0, 180, 0, 0);
        player3.transform.position = new Vector3(0, 0, 0);
        player3.transform.rotation = new Quaternion(0, 180, 0, 0);
        Showplayer(player1);
        PlayerDate playerdate1 = new PlayerDate();
        playerdate1.PH = 500;
        playerdate1.SP = 3;
        playerdate1.JD = 1;
        playerdate1.nam = "player1";
        Playerinfo.Intance.playerlist.Add(playerdate1);
        PlayerDate playerdate2 = new PlayerDate();
        playerdate2.PH = 300;
        playerdate2.SP = 5;
        playerdate2.JD = 3;
        playerdate2.nam = "player2";
        Playerinfo.Intance.playerlist.Add(playerdate2);
        PlayerDate playerdate3 = new PlayerDate();
        playerdate3.PH = 100;
        playerdate3.SP = 10;
        playerdate3.JD= 2;
        playerdate3.nam = "player3";
        Playerinfo.Intance.playerlist.Add(playerdate3);
        Playerinfo.Intance.playerdate = Playerinfo.Intance.playerlist[0];
    }
    public void Showplayer(GameObject player)
    {
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(false);
        player.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

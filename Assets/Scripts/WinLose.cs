using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour {

    public bool Win;
    public bool Lose;

    public int enemyCount;

    GameObject player;
    PlayerHealth pHealth;

    // Use this for initialization
    void Start () {
        Win = false;
        Lose = false;
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            enemyCount = 3;
        } else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            enemyCount = 1;
        }
        

        player = GameObject.Find("PlayerOne");
        pHealth = player.GetComponent<PlayerHealth>();
    }
	
	// Update is called once per frame
	void Update () {
		if (enemyCount == 0)
        {
            Win = true;
            WinnerWinnerChickenDinner();
        }

        if (pHealth.curHealth < 1)
        {
            Lose = true;
            Losers();
        }
	}

    void WinnerWinnerChickenDinner()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            //Load next scene for boss fight
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            //Go back to main menu
            SceneManager.LoadScene(0);
        }
    }

    void Losers()
    {
        //Load main menu again
        SceneManager.LoadScene(0);
    }
}

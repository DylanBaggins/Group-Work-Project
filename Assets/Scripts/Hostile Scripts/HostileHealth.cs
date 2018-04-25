using UnityEngine;
using System.Collections;

public class HostileHealth : MonoBehaviour
{


    public int maxHealth = 100;
    public int curHealth = 100;
    public int scoreValue = 10;               // The amount added to the player's score when the enemy dies.

    GameObject temp;
    WinLose meh;
    

    //initialization 
    void Start() {
        temp = GameObject.Find("GameManager");
        meh = temp.GetComponent<WinLose>();
    }

    // Update 
    void Update()
    {
        if (curHealth < 1)
        {
            Destroy(gameObject);

            // Increase the score by the enemy's score value.
            Score.score += scoreValue;
            meh.enemyCount -= 1;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerBullet"))
        {
            curHealth -= 25;
            Destroy(other.gameObject);
        }
    }


}

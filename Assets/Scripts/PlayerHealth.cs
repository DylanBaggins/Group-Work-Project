using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Text Healthdisplay;
    public int maxHealth = 100;
    public int curHealth = 100;

    //initialization 
    void Start() { }

    // Update 
    void Update()
    {
        if (curHealth < 1)
        {
            Destroy(gameObject);
        }



        Healthdisplay.text = curHealth.ToString();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("HostileBullet"))
        {
            curHealth -= 1;
            Destroy(other.gameObject);
        }
    }
}
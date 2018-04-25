using UnityEngine;
using System.Collections;

public class HostileOneFireScript : MonoBehaviour {

    public GameObject HostileBullet;

    // Use this for initialization
    void Start()
    {
        //(start) (delay)
        InvokeRepeating("FireEnemyBullet", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FireEnemyBullet()
    {
        GameObject player = GameObject.Find("PlayerOne");

        if (player != null)
        {
            GameObject bullet = (GameObject)Instantiate(HostileBullet);

            bullet.transform.position = transform.position;

            Vector2 direction = player.transform.position - bullet.transform.position;

            bullet.GetComponent<HostileBullet>().SetDirection(direction);
        }
    }
}

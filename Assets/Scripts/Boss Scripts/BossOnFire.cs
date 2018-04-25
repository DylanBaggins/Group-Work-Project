using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOnFire : MonoBehaviour {

    public GameObject HostileBullet;

    public Vector3 offset = new Vector3(5, 0, 0);

    // Use this for initialization
    void Start()
    {
        //(start) (delay)
        InvokeRepeating("FireEnemyBullet", 1f, 0.5f);
    }

    void FireEnemyBullet()
    {
        GameObject player = GameObject.Find("PlayerOne");

        if (player != null)
        {
            GameObject bullet = (GameObject)Instantiate(HostileBullet);
            GameObject bullet1 = (GameObject)Instantiate(HostileBullet);
            GameObject bullet2 = (GameObject)Instantiate(HostileBullet);

            bullet.transform.position = transform.position;
            bullet1.transform.position = transform.position;
            bullet2.transform.position = transform.position;

            Vector2 direction = player.transform.position - bullet.transform.position;
            Vector2 direction1 = (player.transform.position - offset) - bullet1.transform.position;
            Vector2 direction2 = (player.transform.position + offset) - bullet2.transform.position;

            bullet.GetComponent<HostileBullet>().SetDirection(direction);
            bullet1.GetComponent<HostileBullet>().SetDirection(direction1);
            bullet2.GetComponent<HostileBullet>().SetDirection(direction2);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOne2ndFire : MonoBehaviour {

    public GameObject HostileBullet;

    public Vector3 offset = new Vector3(5, 0, 0);

    // Use this for initialization
    void Start()
    {
        //(start) (delay)
        InvokeRepeating("FireEnemyBullet", 2f, 2f);
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

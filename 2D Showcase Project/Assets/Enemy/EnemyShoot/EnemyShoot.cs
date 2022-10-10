using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject bullet;
    public float bulletSpeed = 5.0f;
    public float bulletLifetime = 3.0f;
    public GameObject Player;
    public float close = 10.0f;
    public float shootDelay = 1.0f;
    float timer = 0.0f;
    public AudioClip enemyShotSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = Player.transform.position - transform.position;
        float shootDist = shootDir.magnitude;
        shootDir.Normalize();

        if (shootDist <= close)
        {
            if(timer >= shootDelay)
            {
                //shoot 
                timer = 0;
                GameObject bulletSpawn = Instantiate(bullet, transform.position, Quaternion.identity);
                bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
                Destroy(bulletSpawn, bulletLifetime);
               Camera.main.GetComponent<AudioSource>().PlayOneShot(enemyShotSound);
            }
        }

    }
}

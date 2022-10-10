using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Damage")
        {
            enemyHealth--;
            if (enemyHealth <= 0)
            {
                
                
                
                SceneManager.LoadScene("CheeseBoss");

            }
        }
    }
}

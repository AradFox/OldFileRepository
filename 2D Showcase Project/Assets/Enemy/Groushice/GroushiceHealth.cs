using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroushiceHealth : MonoBehaviour
{
    public int groushiceHealth = 100;

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
            groushiceHealth--;
            if (groushiceHealth <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("YouWon");
            }
        }
    }
}

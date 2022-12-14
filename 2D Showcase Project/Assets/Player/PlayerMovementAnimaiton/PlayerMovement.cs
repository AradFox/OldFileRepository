using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        float yInput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("xInput", xInput);
        GetComponent<Animator>().SetFloat("yInput", yInput);
        Vector2 MoveDirection = new Vector2(xInput, yInput);
        GetComponent<Rigidbody2D>().velocity = MoveDirection * speed;
    }
}

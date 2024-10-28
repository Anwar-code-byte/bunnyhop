using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbitScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float rabHop;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * rabHop;
        }   
    }
}

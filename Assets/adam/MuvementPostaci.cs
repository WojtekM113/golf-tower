using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MuvementPostaci : MonoBehaviour
{
    public float speed;
    public float Move;
    


    private Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        
            rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {


        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

    }  

    
    
   
    
        
    



}



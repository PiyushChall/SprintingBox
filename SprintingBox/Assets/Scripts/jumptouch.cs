using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumptouch : MonoBehaviour
{
    public float x;
    public float y;
    public Rigidbody2D rb;
    public float jumpforce;
    private bool isGrounded;
    public float checkRadius = 0.2f;
    public bool isJumping;
    public float jumpTimeCounter;
    public float jumpTime;

    [SerializeField] public Transform groundCheck;
    [SerializeField] public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0 )
        {
            rb.gravityScale *= -1;
        }
        
    }
   
}

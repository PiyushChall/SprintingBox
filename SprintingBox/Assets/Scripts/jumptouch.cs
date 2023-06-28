using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumptouch : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public AudioClip sfx;
    public AudioSource souunds;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        float moveX = SimpleInput.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
    }
    public void gravity()
    {
        rb.gravityScale *= -1;
        souunds.clip = sfx;
        souunds.Play();
    }
   
   
}

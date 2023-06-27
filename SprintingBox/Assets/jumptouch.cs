using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumptouch : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpforce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            rb.velocity = Vector2.up * jumpforce;
        }
    }
}

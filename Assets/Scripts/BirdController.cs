using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
   private Rigidbody2D rb;
    [SerializeField] private float jumpSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        BirdJump();
    }
    private void BirdJump()
    {
        if(Input.GetMouseButtonDown(0))
        rb.velocity = Vector2.up * jumpSpeed;
    }
}

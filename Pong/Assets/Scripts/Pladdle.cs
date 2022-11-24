using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pladdle : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Speed = 10;
    private float vertical;
    private IPaddleInput input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = GetComponent<IPaddleInput>();
    }

    private void Update()
    {
        vertical = input.Vertical;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, vertical * Speed);
    }
}
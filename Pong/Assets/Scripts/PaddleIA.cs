using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleIA : MonoBehaviour, IPaddleInput
{
    public float Vertical { get; private set; }

    public Ball ball;

    public void GetInput()
    {
        if (ball.rb.velocity.x > 0)
        {
            if (ball.transform.position.y > transform.position.y)
            {
                Vertical = 1;
            }
            else
            {
                Vertical = -1;
            }
        }
        else
        {
            Vertical = 0;
        }
    }

    private void Update()
    {
        GetInput();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPaddleInput
{
    float Vertical { get; }

    void GetInput();
}
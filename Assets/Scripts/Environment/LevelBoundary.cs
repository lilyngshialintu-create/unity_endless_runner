using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide =-3.5f;
    public static float rightSide =3.5f;//stated the boudaries
    public float internalLeft;
    public float internalRight;
    //static allows other scripts to interact with the variables, does not appear in inspector panel
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}

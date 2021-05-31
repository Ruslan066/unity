using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Animator camMove;

    public void Move()
    {
        camMove.SetTrigger("move");
    }
}

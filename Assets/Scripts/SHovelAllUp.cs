using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SHovelAllUp : MonoBehaviour
{
    public Transform obj;
    public float speed;
    void Update()
    {
        if (obj.position.y > -8f)
        {

            obj.position = Vector2.MoveTowards(obj.position, new Vector2(obj.position.x, -8f),
                speed * Time.deltaTime);
        }
        else
        {
            while (obj.position.y < 8f)
                obj.position = Vector2.MoveTowards(obj.position, new Vector2(obj.position.x, 8f),
            speed * Time.deltaTime);
        }

    }
}

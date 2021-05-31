using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShohelUp : MonoBehaviour
{
    public Transform obj;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (obj.position.y < -2.5f)
        {

            obj.position = Vector2.MoveTowards(obj.position, new Vector2(obj.position.x, -2.5f),
                speed * Time.deltaTime);
        }
        else
        {
            while (obj.position.y > -7.8f)
                obj.position = Vector2.MoveTowards(obj.position, new Vector2(obj.position.x, -7.8f),
            speed * Time.deltaTime);
        }

        
       


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform player;
    private float speed = 100f;
    void OnMouseDrag()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = mousePos.y > 4f ? 4f : mousePos.y;
        mousePos.y = mousePos.y < -4f ? -4f : mousePos.y;
        player.position = Vector2.MoveTowards(player.position, new Vector2(player.position.x, mousePos.y),
            speed * Time.deltaTime);
    }
}

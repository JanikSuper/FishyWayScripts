using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkyMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -40;

    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

    }
}

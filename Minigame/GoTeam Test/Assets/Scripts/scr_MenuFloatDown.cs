using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_MenuFloatDown : MonoBehaviour
{

    public float moveSpeed = 0.1f;
    public float maxMove = 10f;

    void FixedUpdate()
    {
        var axisY = moveSpeed + transform.position.y;
        transform.position = new Vector3(transform.position.x, axisY, transform.position.z);
        maxMove -= moveSpeed;
        if (maxMove > 100)
        {
            Destroy(this);
        }
    }
}

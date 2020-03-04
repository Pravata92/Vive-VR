using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{

    public Transform positionTarget;
    public bool bInvert = false;

    void LateUpdate()
    {
        if (!Camera.main)
        {
            return;
        }

        if (positionTarget)
        {
            transform.position = positionTarget.position;
        }
        var target = Camera.main.transform.position;
        target.y = transform.position.y;

        transform.LookAt(target);

        if (bInvert)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y * -1, transform.rotation.z, transform.rotation.w);
        }
    }
}

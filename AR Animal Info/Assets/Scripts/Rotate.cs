using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPos;
    private Quaternion rotationy;
    private Quaternion rotationx;
    private float rotatespeedmodifier = 0.1f;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                rotationy = Quaternion.Euler(0f, -touch.deltaPosition.x * rotatespeedmodifier, 0f);
                transform.rotation = rotationy * transform.rotation;
            }
            if(touch.phase == TouchPhase.Moved)
            {
                rotationx = Quaternion.Euler(touch.deltaPosition.y * rotatespeedmodifier, 0f, 0f);
                transform.rotation = rotationx * transform.rotation;
            }

        }
    }

   
}

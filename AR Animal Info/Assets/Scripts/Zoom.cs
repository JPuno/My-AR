using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoomSize;
    public Camera Zoomcamera;
    
    void Update()
    {

        Zoomcamera.orthographicSize = zoomSize;
       
    }

    public void AdjustZoom(float newZoomsize)
    {
        zoomSize = newZoomsize;
    }
}

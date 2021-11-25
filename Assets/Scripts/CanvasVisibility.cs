using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasVisibility : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;

    public void setEnableCanvas(bool state){
        canvas.enabled = state;
    }
}

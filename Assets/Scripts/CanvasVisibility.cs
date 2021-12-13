using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasVisibility : MonoBehaviour
{   
    // Enabled Desactiva/Activa Componentes dentro de un GameObject
    // SetActive Activa/Desactiva a GameObjects
    [SerializeField]
    Canvas canvas;

    [SerializeField]
    GameObject canvas2;

    public void setEnableCanvas(bool state){
        //Propiedad
        canvas.enabled = state;
    }

    public void setActiveCanvas(bool state){
        //Metodo
        canvas2.SetActive(state);
    }
}

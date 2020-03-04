using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResponderConTeclado : MonoBehaviour
{
    public Button boton;
    public Button boton2;
    public Button boton3;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            boton.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            boton2.onClick.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            boton3.onClick.Invoke();
        }
    }
   

}

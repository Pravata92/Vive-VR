using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonInicio : MonoBehaviour
{
    public GameObject jorgitoElVR;
    public Button startButton;
  
    public void InicioSim()
    {
        jorgitoElVR.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            startButton.onClick.Invoke();
        }
    }
}

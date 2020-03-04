using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataControler : MonoBehaviour
{
    public Text textoPreguntas;
    int index;
    public DataPreguntas[] datosCuestionario;
    public Button boton;
    public Button boton2;
    public Button boton3;
    private GameObject panelFinal;
    private GameObject vamoDeNuevo;
    private void Start()
    {
        panelFinal = GameObject.Find("Ganaste");
        vamoDeNuevo = GameObject.Find("VamoDenuevo");
        vamoDeNuevo.SetActive(false);
        panelFinal.SetActive(false);
        MostrarPreguntas();
        MostrarRespuestas();
    }


    public void MostrarPreguntas()
    {
        Debug.Log("<b>MostrarPreguntas: </b> called index : " + index);
        textoPreguntas.text = datosCuestionario[index].textoPreguntas;
    }


    public void MostrarRespuestas()
    {
        Debug.Log("<b>MostrarRespuestas: </b> called");
        boton.transform.GetComponentInChildren<Text>().text = datosCuestionario[index].dataRespuestas[0].textoRespuestas;
        boton2.transform.GetComponentInChildren<Text>().text = datosCuestionario[index].dataRespuestas[1].textoRespuestas;
        boton3.transform.GetComponentInChildren<Text>().text = datosCuestionario[index].dataRespuestas[2].textoRespuestas;
    }


    public void ResponderPreguntas(int i)
    {
        Debug.Log("<b>ResponderPreguntas: </b> called argumento: "+ i);
        if (datosCuestionario[index].dataRespuestas[i].esCorrecto == true)
        {
            index++;
           
            if (index >= datosCuestionario.Length)
            {
                Terminaste();
                return;
            }
            MostrarPreguntas();
            MostrarRespuestas();
        }
        else if (datosCuestionario[index].dataRespuestas[i].esCorrecto == false)
        {
            VamoDeNuevo();
        }
    }

    IEnumerator IniciandoSimulacion()
    {
        panelFinal.GetComponentInChildren<Text>().text = "Excelente! Iniciando Simulacion en: 3";
        yield return new WaitForSeconds(1);

        panelFinal.GetComponentInChildren<Text>().text = "Excelente! Iniciando Simulacion en: 2";
        yield return new WaitForSeconds(1);

        panelFinal.GetComponentInChildren<Text>().text = "Excelente! Iniciando Simulacion en: 1";
        yield return new WaitForSeconds(1);

        Invoke("CargarEscena", 0.0f);
    }




    void Terminaste()
    {
        panelFinal.SetActive(true);
        StartCoroutine(IniciandoSimulacion());
    }

    void VamoDeNuevo()
    {
        vamoDeNuevo.SetActive(true);
    }
    public void Reintentar()
    {
        vamoDeNuevo.SetActive(false);
    }

    public void CargarEscena()
    {
        SceneManager.LoadScene("Cotoyo");
    }
}


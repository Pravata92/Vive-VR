using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text textoDinamico;
    private int index;
    public GameObject canvasGO;
    public GameObject cartelMartillo;
    public GameObject cartelRodillo;
    public GameObject cartelDestornillador;
    public GameObject luz1;
    public GameObject luz2;
    public GameObject plataforma;
    public GameObject fence;
    public GameObject fence2;
    public GameObject luz3;
    public GameObject luz4;


    void Start()
    {
        index = 4;
        textoDinamico.text = "Objetos Restantes: " + index;
        canvasGO.SetActive(false);
        cartelMartillo.SetActive(false);
        cartelRodillo.SetActive(false);
        cartelDestornillador.SetActive(false);
        luz1.SetActive(false);
        luz2.SetActive(false);
        plataforma.SetActive(false);
        fence2.SetActive(false);
        luz3.SetActive(false);
        luz4.SetActive(false);
    }

    public void  EncenderLuces()
    {
        luz1.SetActive(true);
        luz3.SetActive(true);
    }

    public void EncenderLuces2()
    {
        luz2.SetActive(true);
        luz4.SetActive(true);
    }
    public void ApagarLuces()
    {
        luz1.SetActive(false);
        luz3.SetActive(false);
    }

    public void ApagarLuces2()
    {
        luz2.SetActive(false);
        luz4.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ColisionMesa : MonoBehaviour
{
    public GameController GC;
    private int index;
    void Start()
    {
        index = 4;
    }

    public void OnCollisionEnter(Collision col)
    {
        var a = col.gameObject.GetComponent<ElementoInteractivo>();
        if (!a)
        {
            Debug.Log("NO HAY ");
            return;
        }

            index--;
            GC.textoDinamico.text = "Objetos restantes " + index;
            if (index == 0)
            {
                Terminaste();
            }

        if (a.nombreElemento == "Matafuego")
        {
            GC.canvasGO.SetActive(true);
            GC.canvasGO.GetComponentInChildren<Text>().text = "Matafuego: OK";
        }
        if (a.nombreElemento == "Martillo")
        {
            GC.cartelMartillo.SetActive(true);
            GC.cartelMartillo.GetComponentInChildren<Text>().text = "Martillo: OK";
        }
        if (a.nombreElemento == "Rodillo")
        {
            GC.cartelRodillo.SetActive(true);
            GC.cartelRodillo.GetComponentInChildren<Text>().text = "Rodillo: OK";
        }
        if (a.nombreElemento == "Destornillador")
        {
            GC.cartelDestornillador.SetActive(true);
            GC.cartelDestornillador.GetComponentInChildren<Text>().text = "Destornillador: OK";
        }
    }
    public void OnCollisionExit(Collision col)
    {
        var a = col.gameObject.GetComponent<ElementoInteractivo>();
        if (!a)
        {
            Debug.Log("NO HAY ");
            return;
        }
        index++;
            GC.textoDinamico.text = "Objetos restantes " + index;
        if (a.nombreElemento == "Matafuego")
        {
            GC.canvasGO.SetActive(false);
            GC.canvasGO.GetComponentInChildren<Text>().text = "Matafuegos";
        }
        if (a.nombreElemento == "Martillo")
        {
            GC.cartelMartillo.SetActive(false);
            GC.cartelMartillo.GetComponentInChildren<Text>().text = "Martillo";
        }
        if (a.nombreElemento == "Rodillo")
        {
            GC.cartelRodillo.SetActive(false);
            GC.cartelRodillo.GetComponentInChildren<Text>().text = "Rodillo";
        }
        if (a.nombreElemento == "Destornillador")
        {
            GC.cartelDestornillador.SetActive(false);
            GC.cartelDestornillador.GetComponentInChildren<Text>().text = "Destornillador";
        }
    }
    IEnumerator Plataforma()
    {
        yield return new WaitForSeconds(1);
        GC.textoDinamico.text = "Dirijase a la nueva area en: 3";
        yield return new WaitForSeconds(1);
        GC.textoDinamico.text = "Dirijase a la nueva area en: 2";
        yield return new WaitForSeconds(1);
        GC.textoDinamico.text = "Dirijase a la nueva area en: 1";
        yield return new WaitForSeconds(1);
        GC.plataforma.SetActive(true);
        GC.textoDinamico.text = "Dirijase al Galpon y encienda las luces";
        GC.fence.SetActive(false);
        GC.fence2.SetActive(true);
    }
    

    public void Terminaste()
    {
        GC.textoDinamico.text = "Terminaste! Muy bien";
        StartCoroutine(Plataforma());
    }
}

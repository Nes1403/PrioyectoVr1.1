using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorVida : MonoBehaviour
{
    static public ControladorVida Este;
    public Image[] corazones;  
    private int vidaActual;    


    private void Awake(){
        if(Este == null){
            Este = this;
        }
        else{
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        vidaActual = corazones.Length;
        ActualizarCorazones();
    }

    public void RecibirDanio()
    {
        if (vidaActual > 0)
        {
            vidaActual--;
            ActualizarCorazones();
        }
        if(vidaActual <= 0){
            ManagerJuego.Este.TerminarJuego();
        }
    }

    public void ReiniciarVida()
    {
        vidaActual = corazones.Length;
        ActualizarCorazones();
    }

    private void ActualizarCorazones()
    {
        for (int i = 0; i < corazones.Length; i++)
        {
            corazones[i].gameObject.SetActive(i < vidaActual);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PantallaInicio : MonoBehaviour
{
    public Canvas canvasInicio;
    public Canvas canvasFinal;
    private Transform botonInicio;
    private Button inicio;
    private Button final;


    void Start(){
        Transform botonInicio = canvasInicio.transform.Find("BotonInicio");
        Transform botonFinal = canvasFinal.transform.Find("BotonFinal");
        if(botonInicio != null){
            inicio = botonInicio.GetComponent<Button>();
            inicio.onClick.AddListener(empezar);
        }
        if(botonFinal != null){
            final = botonFinal.GetComponent<Button>();
            final.onClick.AddListener(Reiniciar);
        }
        canvasFinal.gameObject.SetActive(false);
    }

    public void empezar(){
        canvasInicio.gameObject.SetActive(false);
        ManagerJuego.Este.Inicio();
    }

    public void Reiniciar(){
        canvasFinal.gameObject.SetActive(false);
        canvasInicio.gameObject.SetActive(true);
        ControladorVida.Este.ReiniciarVida();
        ControladorPuntaje.Este.ActualizarPuntaje(0);
        ControladorTiempo.Este.ActualizarTiempo(0);
    }

    public void mostrarFinal(){
        canvasFinal.gameObject.SetActive(true);
    }
}

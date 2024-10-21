using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System;


public class ControladorPuntaje : MonoBehaviour
{
    static public ControladorPuntaje Este;
    
    private void Awake(){
        if(Este == null){
            Este = this;
        }
        else{
            Destroy(gameObject);
        }
    }


    public TextMeshProUGUI textoTiempo;

    public void ActualizarPuntaje(int NuevoTiempo){
        textoTiempo.text = NuevoTiempo.ToString();
    }
}


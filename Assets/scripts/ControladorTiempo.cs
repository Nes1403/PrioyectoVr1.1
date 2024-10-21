using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System;

public class ControladorTiempo : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    static public ControladorTiempo Este;


    private void Awake(){
        if(Este == null){
            Este = this;
        }
        else{
            Destroy(gameObject);
        }
    }

    public void ActualizarTiempo(int NuevoTiempo){
        textoTiempo.text = NuevoTiempo.ToString();
    }

}

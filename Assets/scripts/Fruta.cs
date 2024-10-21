using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : ObjetosLanzar
{


    private int contadorColisiones = 0;
    public override void Activar(){
        Destroy(gameObject);
    }


    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("espada")){
            ControladorPuntaje.Este.ActualizarPuntaje(100);
            Activar();
        }
        if (collision.gameObject.CompareTag("piso"))
        {
            contadorColisiones++;
            if (contadorColisiones >= 2)
            {
                Debug.LogWarning("Fruta destruida después de 2 colisiones con el piso");
                Activar();
                ControladorVida.Este.RecibirDanio();
            }
            else
            {
                Debug.LogWarning("Colisión con el piso: " + contadorColisiones);
            }
        }
    }
}


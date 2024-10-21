using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : ObjetosLanzar
{
    private int contadorColisiones = 0;
    public override void Activar(){
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("espada")){
            ControladorVida.Este.RecibirDanio();
        }
        if (collision.gameObject.CompareTag("piso"))
        {
            contadorColisiones++;
            if (contadorColisiones >= 2)
            {
                Debug.LogWarning("Fruta destruida después de 2 colisiones con el piso");
                Activar();
            }
            else
            {
                Debug.LogWarning("Colisión con el piso: " + contadorColisiones);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ManagerJuego : MonoBehaviour
{
    static public ManagerJuego Este;

    private bool JuegoActivo = true;

    public int LimiteTiempo = 20;

    private int ContadorTiempo;

    public UnityEvent<int> ActualizaTiempo;

    public UnityEvent TerminaJuego;

    private void Awake(){
        if(Este == null){
            Este = this;
        }
        else{
            Destroy(gameObject);
        }
    }

    public IEnumerator IniciarContadorTiempo(){
        ContadorTiempo = LimiteTiempo;
        while (0<ContadorTiempo && JuegoActivo){
            yield return new WaitForSecondsRealtime(1);
            ContadorTiempo--;
            ActualizaTiempo?.Invoke(ContadorTiempo);
        }

        TerminarJuego();
        JuegoActivo = false;
    }

    public void TerminarJuego(){
        JuegoActivo= false;
        TerminaJuego?.Invoke();
        Debug.Log("¡Tiempo terminado!");
    }

    public void Inicio(){
        JuegoActivo=true;
        StartCoroutine(IniciarContadorTiempo());
        StartCoroutine(GenerarObjetos());
    }

    IEnumerator GenerarObjetos(){
        while (JuegoActivo) 
        {
            int cantidadObjetos = Random.Range(1, 4 + 1);

            for (int i = 0; i < cantidadObjetos; i++)
            {
                PuntoAparicion.Este.AparecerObjeto(); 
            }

            float tiempoEspera = Random.Range(2f, 5f);
            yield return new WaitForSeconds(tiempoEspera);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerJuego : MonoBehaviour
{
    static public ManagerJuego Este;

    private void Awake(){
        if(Este == null){
            Este = this;
        }
        else{
            Destroy(gameObject);
        }
    }

    public float LimiteTiempo = 0f;

    public IEnumerator IniciarContadorTiempo(){
        while (LimiteTiempo > 0){
            yield return new WaitForSecondsRealtime(1);
            LimiteTiempo -= 1;
        }

        TerminarJuego();
    }

    void TerminarJuego(){
        // Aquí puedes detener el juego, mostrar la pantalla de Game Over, etc.
        Debug.Log("¡Tiempo terminado!");
    }

    // Start is called before the first frame update
    void Start(){
        StartCoroutine(IniciarContadorTiempo());
        StartCoroutine(GenerarObjetos());
    }

    IEnumerator GenerarObjetos(){
        while (true){
            PuntoAparicion.Este.AparecerObjeto();  // Instancia un objeto al azar
            yield return new WaitForSeconds(2f);  // Tiempo entre apariciones
        }
    }
}

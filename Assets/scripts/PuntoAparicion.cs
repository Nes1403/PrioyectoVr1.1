using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoAparicion : MonoBehaviour
{

    public static PuntoAparicion Este;

    #region aparicion

    public Vector3 Centro;

    public float RadioAparicion;

    public float AlturaAparicion;

    public List<ObjetosLanzar> objetosLanzar;
    #endregion


    private void Awake(){
        if (Este == null)
        {
            Este = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnDrawGizmos(){
        Gizmos.color= Color.yellow;
        Gizmos.DrawWireSphere(Centro + new Vector3(0, 0, AlturaAparicion), RadioAparicion);
    }

    public Vector3 Punto(){
        float Angulo = Random.Range(0, 2*Mathf.PI);

        float Ejex = RadioAparicion * Mathf.Cos(Angulo);
        float Ejey = RadioAparicion * Mathf.Sin(Angulo);
        float Ejez = Centro.z + AlturaAparicion;

        return new Vector3(Ejex, Ejey, Ejez);
    }

    public void AparecerObjeto(){
        ObjetosLanzar objetoAInstanciar = objetosLanzar[Random.Range(0, objetosLanzar.Count)];
    Debug.Log("Instanciando objeto: " + objetoAInstanciar.name);  // Log para verificar la instancia
    GameObject frutaCreada = Instantiate(objetoAInstanciar.gameObject, Punto(), Quaternion.identity);
    }
}


    


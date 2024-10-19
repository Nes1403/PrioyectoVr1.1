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
        float Angulo = Random.Range(0, Mathf.PI);

        float Ejex = RadioAparicion * Mathf.Cos(Angulo);
        float Ejez = RadioAparicion * Mathf.Sin(Angulo);
        float Ejey = Centro.z + AlturaAparicion;

        return new Vector3(Ejex, Ejey, Ejez);
    }

    public void AparecerObjeto(){
        ObjetosLanzar objetoAInstanciar = objetosLanzar[Random.Range(0, objetosLanzar.Count)];
    Debug.Log("Instanciando objeto: " + objetoAInstanciar.name);  // Log para verificar la instancia
    GameObject frutaCreada = Instantiate(objetoAInstanciar.gameObject, Punto(), Quaternion.identity);
    Rigidbody rb = frutaCreada.GetComponent<Rigidbody>();

    if (rb != null)
    {
        // Aplica una fuerza hacia arriba (en el eje Y) para que el objeto se eleve
        float fuerzaVertical = 300f;  // Puedes ajustar este valor según lo que necesites
        rb.AddForce(Vector3.up * fuerzaVertical);
    }
    else
    {
        Debug.LogWarning("El objeto no tiene un Rigidbody, no se puede aplicar la fuerza.");
    }
    }

}


    


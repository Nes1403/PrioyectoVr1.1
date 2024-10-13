using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosLanzar : MonoBehaviour, IActivable
{

    public Rigidbody rb;

    public float velocidad;


    virtual public void Activar(){
        Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}

public interface IActivable{
        void Activar();
    }


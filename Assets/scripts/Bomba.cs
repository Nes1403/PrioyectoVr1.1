using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : ObjetosLanzar
{
    public override void Activar(){
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

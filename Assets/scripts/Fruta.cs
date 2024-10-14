using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruta : ObjetosLanzar
{
    public override void Activar(){
        Destroy(gameObject);
    }
}


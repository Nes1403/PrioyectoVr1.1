using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        IActivable activable = other.GetComponent<IActivable>();
        if (activable != null)
        {
            activable.Activar();  // Activar la fruta o bomba
        }
    }
}


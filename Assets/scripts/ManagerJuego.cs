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
            Destroy(this);
        }
    }

    float LimiteTiempo = 0f;

    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T : GenericSingleton<T>
{
    public static GenericSingleton<T> instate;

    protected void Awake()
    {
        if(instate == null)
        {
            instate = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
   
}

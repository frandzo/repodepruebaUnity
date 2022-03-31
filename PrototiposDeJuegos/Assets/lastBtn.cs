using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastBtn : MonoBehaviour
{
    public int asd;
    public btnBhv last;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        asd = last.gameObject.GetComponent<btnClase>().clase;
    }


}

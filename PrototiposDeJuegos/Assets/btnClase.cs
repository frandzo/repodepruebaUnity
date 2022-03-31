using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnClase : MonoBehaviour
{
    public int clase;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponentInChildren<Text>().text = clase.ToString();
        //this.GetComponentInChildren<Text>().fontSize = 28;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}

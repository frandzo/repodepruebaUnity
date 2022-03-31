using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnBhv : MonoBehaviour
{
    public bool isSelected;
    public lastBtn lastScript;
    public Button normal;
    public Button selected;
    public btnBhv button13;

    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchStatus ()
    {
        if(isSelected)
        {
            isSelected = false;
            this.GetComponent<Button>().colors = normal.colors;
        }
        else
        {
            this.GetComponent<Button>().colors = selected.colors;
            
            if (this.GetComponent<btnClase>().clase == lastScript.last.gameObject.GetComponent<btnClase>().clase)
            {
                this.GetComponent<Button>().interactable = false;
                this.GetComponentInChildren<Text>().text = "";
                lastScript.last.gameObject.GetComponent<Button>().interactable = false;
                lastScript.last.gameObject.GetComponentInChildren<Text>().text = "";
                this.GetComponent<Button>().colors = normal.colors;

                lastScript.last.isSelected = false;
                lastScript.last.gameObject.GetComponent<Button>().colors = normal.colors;
                lastScript.last = this.GetComponent<btnBhv>();

                lastScript.last = button13;

                Debug.Log("last = 13");
            }
            else
            {
                lastScript.last.isSelected = false;
                lastScript.last.gameObject.GetComponent<Button>().colors = normal.colors;
                lastScript.last = this.GetComponent<btnBhv>();
            }
            
            //lastScript.last.isSelected = false;
            //lastScript.last.gameObject.GetComponent<Button>().colors = normal.colors;
            isSelected = true;
            //lastScript.last = this.GetComponent<btnBhv>();
        }

        Debug.Log(this.transform.name+" switched ");
    }
}

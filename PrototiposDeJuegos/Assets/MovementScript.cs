using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Transform TrfObj;
    public float movementSpeed;
    public MovementScript asd;

    // Start is called before the first frame update
    void Start()
    {
        var asd2 = new MovementScript();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            TrfObj.position = TrfObj.position + new Vector3( movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}

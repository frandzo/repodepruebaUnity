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
        if (Input.GetKey(KeyCode.W))
        {
            TrfObj.position = TrfObj.position + new Vector3(0, movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            TrfObj.position = TrfObj.position + new Vector3(0, -movementSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            TrfObj.position = TrfObj.position + new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            TrfObj.position = TrfObj.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
        }
    }
}

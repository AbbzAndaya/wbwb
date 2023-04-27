using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extender : MonoBehaviour
{
    public Transform extender;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 CustomForward = new Vector3(0, 0, 1);
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (extender.localPosition.z < 10)
            {
                extender.Translate(CustomForward * speed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (extender.localPosition.z > -40)
            {
                extender.Translate(CustomForward * -speed * Time.deltaTime);
            }
        }
    }
}

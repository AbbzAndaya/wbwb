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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (extender.localPosition.z < 10)
            {
                extender.Translate(extender.forward * speed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (extender.localPosition.z > -40)
            {
                extender.Translate(-extender.forward * speed * Time.deltaTime);
            }
        }
    }
}

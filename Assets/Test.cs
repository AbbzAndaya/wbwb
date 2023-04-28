using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform crane;
    public Transform move;
    public Transform target;
    public float speed;
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
            {
            source.Stop();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            source.PlayOneShot(clip);
        }
        if (Input.GetKey(KeyCode.D))
        {
            crane.Rotate(Vector3.up, speed * Time.deltaTime);
            
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            source.Stop();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(clip);
        }


        if (Input.GetKey(KeyCode.A))
        {
            crane.Rotate(Vector3.down, speed * Time.deltaTime);
        }
        move.position = target.position;
    }
}
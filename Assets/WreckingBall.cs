using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WreckingBall : MonoBehaviour
{
    public float force;
    public float wreckingballRadius;
    public LayerMask mask;
    public Text uiText;
    public int score;
    public AudioSource source;
    public AudioClip clip;
    
	private void OnCollisionEnter(Collision collision)
    {
        var rb = collision.rigidbody;
        if (rb)
        {
            var colliders = Physics.OverlapSphere(transform.position, wreckingballRadius, mask);
            foreach (var collider in colliders)
            {
                var colliderRb = collider.GetComponent<Rigidbody>();
                if (colliderRb)
                {
                    colliderRb.isKinematic = false;
                    colliderRb.AddExplosionForce(force, transform.position, wreckingballRadius);
                    score += 1000;
                    uiText.text = "Score:" +score;
                   
                }
               
            }
            if (force != 0)
            {
                
            }
           source.PlayOneShot(clip);
        }
    }
}

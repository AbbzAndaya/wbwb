using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBall : MonoBehaviour
{
    public float force;
    public float wreckingballRadius;
    public LayerMask mask;
    
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
                }
            }
            if (force != 0)
            {
                
            }
        }
    }
}

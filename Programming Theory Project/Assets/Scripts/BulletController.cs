using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);

    }

    private void FixedUpdate()
    {
        if(transform.position.y < -3)
        {
            Destroy(gameObject);
        }
    }


}

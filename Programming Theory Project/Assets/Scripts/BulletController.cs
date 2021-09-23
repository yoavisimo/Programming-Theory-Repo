using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    float speed = 30f;

    public delegate void ScoreUpdate(int addition);
    public static ScoreUpdate onScoreUpdate;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);

    }

    private void FixedUpdate()
    {
        if(transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            int addition = other.gameObject.GetComponent<Enemy>().lifeOnImpact;
            onScoreUpdate(addition);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

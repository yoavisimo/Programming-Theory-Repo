using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int lifeOnImpact { get; set; }

    [SerializeField]
    protected Color color;

    [SerializeField]
    protected float movingSpeed = 5f;

    [SerializeField]
    protected float rotationSpeed;

    public virtual void Move()
    {
        transform.Translate(Vector3.back * Time.deltaTime * movingSpeed);
    }

    public virtual void Die()
    {
       
    }

    public virtual void GiveBack()
    {

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

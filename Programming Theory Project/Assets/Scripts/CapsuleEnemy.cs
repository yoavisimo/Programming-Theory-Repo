using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleEnemy : Enemy
{
    
    // Start is called before the first frame update
    void Start()
    {
        this.lifeOnImpact = 1;
        this.movingSpeed = 19;
        this.color = Color.blue;
        Material mat = GetComponent<Renderer>().material;
        mat.color = this.color;
    }

    private void FixedUpdate()
    {
        Move();
    }

    public override void Die()
    {
        base.Die();
    }

    public override void Move()
    {
        transform.Rotate(Vector3.up * movingSpeed * Time.deltaTime, 2f);
        base.Move();
    }

    public override void GiveBack()
    {
        base.GiveBack();
    }

}

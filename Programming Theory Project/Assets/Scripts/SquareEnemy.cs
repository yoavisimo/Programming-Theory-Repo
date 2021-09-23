using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareEnemy : Enemy
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        this.lifeOnImpact = 1;
        this.movingSpeed = 2;
        this.color = Color.green;
        Material mat = GetComponent<Renderer>().material;
        mat.color = this.color;
    }

    private void FixedUpdate()
    {
        Move();
    }


    public override void Move()
    {
        base.Move();
    }

    public override void Die()
    {
        base.Die();
    }

    public override void GiveBack()
    {

    }
}

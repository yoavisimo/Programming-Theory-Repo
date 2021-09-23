using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        this.lifeOnImpact = 1;
        this.color = Color.red;
        Material mat = GetComponent<Renderer>().material;
        mat.color = this.color;
    }

    // Update is called once per frame
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
        base.Move();
    }

    public override void GiveBack()
    {
        base.GiveBack();
    }
}

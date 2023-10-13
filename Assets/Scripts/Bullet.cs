using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : BaseBullet
{
    protected override void Start()
    {
        base.Start();
        Destroy(gameObject, 2f);
    }
}

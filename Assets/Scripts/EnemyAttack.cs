using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float damage = 30f;

    public void Attack()
    {
        if(target == null) return;
        Debug.Log("Hit....!!!");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 30f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    public void Attack()
    {
        if(target == null) return;
        target.TakeDamage(damage);
        //PlayerHealth.instance.TakeDamage(damage); 
        Debug.Log("Hit....!!!");
    }
}

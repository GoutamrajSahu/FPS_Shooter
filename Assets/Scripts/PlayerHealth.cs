using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;
    [SerializeField] float hitPoints = 100f;

    private void Awake()
    {
        instance = this;
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            Debug.Log("GameOver...!");
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}

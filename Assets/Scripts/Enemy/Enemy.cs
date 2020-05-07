﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Security.Cryptography;

public class Enemy : MonoBehaviour
{
    public GameObject[] consumableDrop;
    int random;
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        animator.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

        random = Random.Range(0, consumableDrop.Length);
        Instantiate(consumableDrop[random], new Vector3(transform.position.x, transform.position.y + 0.5f , 0), Quaternion.identity);
        Destroy(this.gameObject);
    }
}

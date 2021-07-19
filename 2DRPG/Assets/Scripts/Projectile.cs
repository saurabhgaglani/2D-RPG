﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Transform player;
    private Vector2 target;
    public float speed;
    public int damage;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);

    }

    void Update()
    {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
            
            if(transform.position.x == target.x && transform.position.y == target.y)
        {
            destroy_projectile();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") //if projectile hits player
        {

            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damage);

        }
    }


    private void destroy_projectile()
    {
        Destroy(gameObject);
    }
}
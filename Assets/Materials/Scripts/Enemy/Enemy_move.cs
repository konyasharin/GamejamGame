using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_move : MonoBehaviour
{
    private Vector2 moveDirection;
    public float speed = 1.0f;
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    moveDirection = (player.position - transform.position).normalized;
    enemyRigidbody.MovePosition(enemyRigidbody.position + moveDirection* moveSpeed * Time.deltaTime);

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FixedUpdate
    }
    private void FixedUpdate()
    {
        moveDirection = (player.position - transform.position).normalized;
        enemyRigidbody.MovePosition(enemyRigidbody.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }
    
}

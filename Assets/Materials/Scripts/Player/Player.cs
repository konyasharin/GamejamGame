using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    [NonSerialized] public bool isAttack;
    public float health = 100;
    public Image healthBar;
    public static Player instance{ get; set; }

    public Player GetInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
        return instance;
    }
    private void Awake()
    {
        GetInstance();
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        isAttack = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health / 100);
        healthBar.fillAmount = health / 100;
        if (!isAttack)
        {
            Move();
        }
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(horizontalInput * speed, VerticalInput * speed, 0);

        if(horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }

        animator.SetFloat("current speed", vector.magnitude);

        transform.Translate(vector);
    }
}

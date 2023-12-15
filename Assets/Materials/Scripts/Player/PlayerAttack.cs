using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator _animator;
    private Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _player = Player.instance;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            _player.isAttack = true;
            _animator.SetTrigger("Attack");
        }
    }

    public void EndAttack()
    {
        _player.isAttack = false;
    }
}

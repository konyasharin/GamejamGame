using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar : MonoBehaviour
{
    public Image healthBar;
    public InfoPlayer player;

    void Start()
    {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<InfoPlayer>();
    }


    void Update()
    {
        healthBar.fillAmount = player.HP / player.maxHP;
    }
}

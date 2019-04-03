using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth;
    private int health;

    void Start(){
        health = maxHealth;
    }

    public GameObject deathMenu;
    public void TakeDamage(int amount){
        health -= amount;
        print(amount);
        if(health <= 0){
            deathMenu.SetActive(true);
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public Transform target;
    public int maxHealth;
    private int health;

    Rigidbody2D rigidbody;

    
[SerializeField] ScoreText scoreText;

    void Awake(){
        scoreText = GameObject.Find("ScoreText").GetComponent<ScoreText>();
        rigidbody = GetComponent<Rigidbody2D>();
        health = maxHealth;
    }
    void FixedUpdate(){
        Vector2 direction = target.position - transform.position;
        rigidbody.AddForce(direction.normalized * moveSpeed * Time.fixedDeltaTime);
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.transform.CompareTag("Bullet")){
            Destroy(other.gameObject);
            health--;
            if(health <= 0)
            {
                scoreText.ChangeScore(1);
                Destroy(this.gameObject);
            }
        }
    }
}

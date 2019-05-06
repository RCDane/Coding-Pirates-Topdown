using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    public float onScreenTime;
    public int damageAmount;
    public LayerMask playerLayer;
    CircleCollider2D coll;
    
    void Start(){
        coll = GetComponent<CircleCollider2D>();
        HasBeenActivated = false;
        gameObject.SetActive(false);
    }
    bool HasBeenActivated;
    float attackTimer;
    float attackTime = 0.3f;
    public void Attack(){
        HasBeenActivated = false;
        attackTimer = Time.timeSinceLevelLoad;
    }
    void OnTriggerEnter2D(Collider2D coll){
        
        if(coll.CompareTag("Player") && !HasBeenActivated && attackTime + attackTimer > Time.timeSinceLevelLoad)
        {
            coll.transform.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
            HasBeenActivated = true;
        }
        StartCoroutine("HitTimer");

    }
    IEnumerator HitTimer(){
        
        yield return new WaitForSeconds(onScreenTime);
        gameObject.SetActive(false);

    }
}

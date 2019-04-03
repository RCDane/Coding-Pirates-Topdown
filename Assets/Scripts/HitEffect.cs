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
    float attackTime;
    public void Attack(){
        HasBeenActivated = false;
        attackTime = Time.timeSinceLevelLoad;
    }
    void OntriggerEnter2D(Collider2D coll){
        if(coll.CompareTag("Player") && !HasBeenActivated)
        {
            coll.transform.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
            HasBeenActivated = true;
        }
        
    }
    IEnumerator HitTimer(){
        
        yield return new WaitForSeconds(onScreenTime);
        gameObject.SetActive(false);

    }
}

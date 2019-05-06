using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public Transform target;
    public Transform hitEffect;
    public float hitDistance;
    public float playerHitDistance;

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = target.position - transform.position;
        if(distance.magnitude < hitDistance && !hitEffect.gameObject.activeSelf)
        {
            hitEffect.gameObject.SetActive(true);
            hitEffect.GetComponent<HitEffect>().Attack();
            hitEffect.position = transform.position + distance.normalized * playerHitDistance;
        }        
    }
}

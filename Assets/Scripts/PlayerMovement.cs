using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rigidbody;

    public float moveSpeed = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        

        Vector2 moveDirection = new Vector2(xMove,yMove);

        rigidbody.AddForce(moveDirection*Time.deltaTime*moveSpeed,ForceMode2D.Impulse);

    }
}

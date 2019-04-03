using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectile;
    public float speed;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector2 mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = mousePos - (Vector2)transform.position;

            GameObject bullet = Instantiate(projectile,transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().AddForce(dir.normalized * speed);
        }
    }


}

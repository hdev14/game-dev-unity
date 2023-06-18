using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviments : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = this.transform.position;

        position.x += horizontal * this.speed * Time.deltaTime;
        position.y += vertical * this.speed * Time.deltaTime;

        this.transform.position = position;
    }
}

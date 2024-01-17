using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float force = 10f;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
}

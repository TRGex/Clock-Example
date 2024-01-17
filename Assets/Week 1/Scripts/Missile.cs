using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 3f;
    public GameObject missilePrefab;
    public Transform spawn;

    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(10 * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rigidbody.MovePosition(rigidbody.position + direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Missile collision");
        Destroy(gameObject);
    }
}

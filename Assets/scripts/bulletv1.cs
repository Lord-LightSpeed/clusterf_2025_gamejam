using UnityEngine;

public class bulletv1 : MonoBehaviour
{
    private GameObject self;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * 10f;
        self = GetComponent<GameObject>();
        Destroy(self);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("boundary"))
        {
            Destroy(collision);
            Destroy(self);
        }
    }
}

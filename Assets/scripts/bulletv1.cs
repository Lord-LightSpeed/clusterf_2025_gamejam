using System.Data.Common;
using System.Threading;
using UnityEngine;

public class bulletv1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private double time_to_die;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * 10f;
        time_to_die = double.MaxValue;
    }

    void Update()
    {
        if (Time.timeSinceLevelLoadAsDouble >= time_to_die)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("boundary"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    void OnBecameInvisible()
    {
        time_to_die = Time.timeSinceLevelLoadAsDouble + 30d;
    }
    void OnBecameVisible()
    {
        time_to_die = double.MaxValue;
    }
}

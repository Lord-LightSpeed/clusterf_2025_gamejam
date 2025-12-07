using UnityEngine;

public class player_mover : MonoBehaviour
{
    public Camera camera;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        exposeplayer.player = rb.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float moveInputH = Input.GetAxis("Horizontal");
        float moveInputV = Input.GetAxis("Vertical");
        rb.linearVelocity = new Vector2(moveInputH * 5f, moveInputV * 5f);
        camera.transform.position = new Vector3(rb.position.x, rb.position.y, -10f);
    }
}

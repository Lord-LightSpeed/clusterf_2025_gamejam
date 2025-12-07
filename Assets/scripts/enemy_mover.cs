using UnityEngine;

public class enemy_mover : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D self;
    private Transform wherethefuckami;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        self = GetComponent<Rigidbody2D>();
        wherethefuckami = GetComponent<Transform>();
        player = exposeplayer.player;
    }

    // Update is called once per frame
    void Update()
    {
        player = exposeplayer.player;
        Vector3 timetogetavec2 = (player.transform.position - wherethefuckami.position).normalized;
        Vector2 dirvec = new Vector2(timetogetavec2.x, timetogetavec2.y);
        self.linearVelocity = dirvec * 2f;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit(1);
        }
    }
}

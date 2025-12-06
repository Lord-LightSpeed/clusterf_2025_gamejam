using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform turret;
    public GameObject player;
    private Transform playerloc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerloc = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, playerloc.position, turret.rotation);
        }
    }
}

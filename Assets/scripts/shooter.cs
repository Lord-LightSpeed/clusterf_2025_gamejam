using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject bullet;
    private Rigidbody2D turret;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turret = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, turret.position, Quaternion.Euler(0, 0, turret.rotation));
        }
    }
}

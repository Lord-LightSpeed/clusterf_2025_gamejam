using Unity.Mathematics;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public Camera camera;
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
        Vector3 vecToMouse = camera.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,10)) - playerloc.position;
        turret.rotation = quaternion.Euler(0, 0, math.atan2(vecToMouse.y, vecToMouse.x) - math.PIHALF);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, playerloc.position, turret.rotation);
        }
    }
}

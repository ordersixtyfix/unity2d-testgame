using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragShoot : MonoBehaviour

{
    public float power = 5f;
    public Rigidbody2D rb;


    public Vector2 minPower;
    public Vector2 maxPower;
    TrajectoryLine tl;


    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    private void Start()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        cam = Camera.main;
        tl = GetComponent<TrajectoryLine>();


    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.constraints = RigidbodyConstraints2D.None;
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;
        }

        if (Input.GetMouseButton(0))
        {
            rb.constraints = RigidbodyConstraints2D.None;
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPoint.z = 15;
            tl.RenderLine(startPoint, currentPoint);

        }
        if (Input.GetMouseButtonUp(0))
        {
            rb.constraints = RigidbodyConstraints2D.None;
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;

            force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);
            tl.EndLine();
        }
    }

}

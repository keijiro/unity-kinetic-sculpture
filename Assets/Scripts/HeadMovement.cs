using UnityEngine;
using System.Collections;

public class HeadMovement : MonoBehaviour
{
    public float speed = 3.0f;
    public float radius = 0.4f;
    float r1;
    float r2;
    float vr1;
    float vr2;

    void Start ()
    {
        vr1 = Random.Range (0.1f, 0.5f) * speed;
        vr2 = Random.Range (0.1f, 0.5f) * speed;
    }
    
    void FixedUpdate ()
    {
        r1 += vr1 * Time.fixedDeltaTime;
        r2 += vr2 * Time.fixedDeltaTime;
        var position = new Vector3 (Mathf.Sin (r1) * radius, transform.position.y, Mathf.Sin (r2) * radius);
        rigidbody.MovePosition (position);
    }
}

using UnityEngine;
using System.Collections;

public class HeadMovement : MonoBehaviour
{
    float r1;
    float r2;
    float vr1;
    float vr2;

    void Start ()
    {
        vr1 = Random.Range (0.1f, 0.5f);
        vr2 = Random.Range (0.1f, 0.5f);
    }
    
    void FixedUpdate ()
    {
        r1 += vr1 * Time.fixedDeltaTime;
        r2 += vr2 * Time.fixedDeltaTime;
        var position = new Vector3 (Mathf.Sin (r1), transform.position.y, Mathf.Sin (r2));
        rigidbody.MovePosition (position);
    }
}

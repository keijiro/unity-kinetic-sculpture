using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour
{
    public float rotation = 5.0f;
    public float omega = 0.3f;
    float time;

    void Start()
    {
        omega *= Random.Range (0.5f, 2.0f);
    }

    void Update ()
    {
        time += omega * Time.deltaTime;
        transform.localRotation = 
            Quaternion.AngleAxis (Mathf.Sin (time) * rotation, Vector3.up);
    }
}

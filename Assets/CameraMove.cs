using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    public float yaw = 90.0f;

    void Update ()
    {
        transform.localRotation =
            Quaternion.AngleAxis (yaw * Time.deltaTime, Vector3.up) * transform.localRotation;
    }
}

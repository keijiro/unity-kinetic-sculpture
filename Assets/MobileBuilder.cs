using UnityEngine;
using System.Collections;

public class MobileBuilder : MonoBehaviour
{
    public GameObject barPrefab;
    public int iteration = 10;
    public float interval = 0.25f;
    public float slide = 0.5f;

    void Start ()
    {
        var position = transform.position;
        var rotation = transform.rotation;
        var prev = gameObject;

        for (var i = 0; i < iteration; i++)
        {
            position -= Vector3.up * interval;
            position += Vector3.right * slide;

            slide *= -1;

            var bar = Instantiate(barPrefab, position, rotation) as GameObject;
            var joint = bar.AddComponent<HingeJoint> ();
            joint.axis = Vector3.up;
            joint.connectedBody = prev.rigidbody;

            prev = bar;
        }
    }
}

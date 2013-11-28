using UnityEngine;
using System.Collections;

public class MobileBuilder : MonoBehaviour
{
    public GameObject barPrefab;
    public int iteration = 10;
    public float interval = 0.25f;
    public float pivot = 0.8f;

    void Start ()
    {
        var position = transform.position;
        var rotation = transform.rotation;
        var prev = gameObject;

        for (var i = 0; i < iteration; i++)
        {
            position -= Vector3.up * interval;

            var bar = Instantiate(barPrefab, position, rotation) as GameObject;

#if false
            var joint = bar.AddComponent<HingeJoint> ();
            joint.anchor = position + Vector3.right * pivot;
            joint.axis = Vector3.up;
            joint.connectedBody = prev.rigidbody;
#else
            var joint = bar.AddComponent<ConfigurableJoint> ();

            joint.anchor = position + Vector3.right * pivot;
            joint.axis = Vector3.up;
            joint.connectedBody = prev.rigidbody;

            joint.angularXMotion = ConfigurableJointMotion.Free;
            joint.angularYMotion = ConfigurableJointMotion.Locked;
            joint.angularZMotion = ConfigurableJointMotion.Locked;

            joint.xMotion = ConfigurableJointMotion.Locked;
            joint.yMotion = ConfigurableJointMotion.Locked;
            joint.zMotion = ConfigurableJointMotion.Locked;
#endif

            prev = bar;
            pivot *= -1.0f;
        }
    }
}

using UnityEngine;
using System.Collections;

public class MobileBuilder2 : MonoBehaviour
{
    public GameObject barPrefab;
    public int iteration = 20;
    public float interval = 0.12f;
    public float slide = 0.2f;

    void Start ()
    {
        var position = transform.position;
        var rotation = transform.rotation;
        var prev = gameObject;

        for (var i = 0; i < iteration; i++)
        {
            position -= Vector3.up * interval;
            position += Vector3.right * slide * Random.value;

            var bar = Instantiate(barPrefab, position, rotation) as GameObject;
            bar.transform.parent = prev.transform;

            prev = bar;
        }
    }
}

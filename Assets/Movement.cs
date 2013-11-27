using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    IEnumerator Start ()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range (2.0f, 8.0f));
            rigidbody.angularVelocity = new Vector3(0, Random.Range (-3.0f, 3.0f), 0);
        }
    }
}

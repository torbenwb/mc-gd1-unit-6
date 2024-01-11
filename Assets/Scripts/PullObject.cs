using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PullObject : MonoBehaviour
{
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Push(float strength)
    {
        Vector3 pushDirection = transform.position - Camera.main.transform.position;
        pushDirection.Normalize();

        rigidbody.AddForce(pushDirection * strength, ForceMode.Impulse);
    }

}

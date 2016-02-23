using UnityEngine;
using System.Collections;

public class LaunchClick : MonoBehaviour {

    public float LaunchForce = 1000;

    void OnMouseDown() {

        rigidbody.AddForce(LaunchForce*transform.forward);

    }
}

using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {
    public Vector3 rotation;

    private Transform transf;

    void Awake() {
        transf = transform;
    }

    void Update() {
        transf.Rotate(rotation);
    }
}

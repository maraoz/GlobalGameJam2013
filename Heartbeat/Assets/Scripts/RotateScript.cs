using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {
    public float speed = 0.1f;

    private Transform transf;

    void Awake() {
        transf = transform;
    }

    void Update() {
        Vector3 ea = transf.eulerAngles;
        ea.y += speed;
        transf.eulerAngles = ea;
    }
}

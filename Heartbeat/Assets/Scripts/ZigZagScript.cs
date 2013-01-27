using UnityEngine;
using System.Collections;

public class ZigZagScript : MonoBehaviour {

    public float radius = 1f;
    public GameObject flame;

    void Start() {

    }

    void Update() {


        float angle = Time.time * 4f;
        //float x = Mathf.Cos(angle) * radius;
        float delta = Mathf.Sin(angle) * radius;

        flame.transform.position = transform.position + transform.right * delta;


    }
}

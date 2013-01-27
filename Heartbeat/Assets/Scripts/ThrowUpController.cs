using UnityEngine;
using System.Collections;

public class ThrowUpController : MonoBehaviour {

    GameObject player;
    public float distance = 0.1f;
    public float strength = 1200f;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() {
        Debug.Log(Vector2.Distance(transform.position, player.transform.position));
        if (Vector2.Distance(transform.position, player.transform.position) < distance) {
            player.rigidbody.velocity = Vector3.zero;
            player.rigidbody.AddForce(Vector3.up * strength);
            enabled = false;
            Destroy(gameObject.transform.parent.gameObject);
        }

    }
}

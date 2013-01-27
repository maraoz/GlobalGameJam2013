using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public float speed = 5f;
    private GameObject target;
    public GameObject close;

    void Update() {
        if (target != null) {
            transform.LookAt(target.transform);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag.Equals("Player")) {
            target = collider.gameObject;
            close.GetComponent<ThrowUpController>().enabled = true;
        }
    }

}

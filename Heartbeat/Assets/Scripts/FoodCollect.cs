using UnityEngine;
using System.Collections;

public class FoodCollect : MonoBehaviour {


    public float growRate = 1.5f;
    private ParticleEmitter[] particles;



    void Awake() {
        particles = this.GetComponentsInChildren<ParticleEmitter>();
    }


    void OnCollisionEnter(Collision collision) {
        if (collision.collider.gameObject.tag == "Food") {
            Destroy(collision.collider.gameObject);
            GrowSize();
        }
    }


    void GrowSize() {
        //transform.localScale *= growRate;
        foreach (ParticleEmitter pe in particles) {
            pe.minSize *= growRate;
            pe.maxSize *= growRate;
        }
    }

}

using UnityEngine;
using System.Collections;

public class FoodCollect : MonoBehaviour {

    public Light glow;
    public CapsuleCollider capsuleCollider;
    public float growRate = 1.5f;
    private ParticleEmitter[] particles;
    private ThirdPersonController tpc;



    void Awake() {
        tpc = GetComponent<ThirdPersonController>();
        particles = this.GetComponentsInChildren<ParticleEmitter>();
    }


    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Food") {
            Destroy(collider.gameObject);
            GrowSize();
        }
    }


    void GrowSize() {
        
        tpc.groundedDistance *= growRate;
        tpc.groundedCheckOffset *= growRate;
        glow.intensity *= growRate;
        
        transform.localScale *= growRate;
        foreach (ParticleEmitter pe in particles) {
            pe.minSize *= growRate;
            pe.maxSize *= growRate;
        }
    }

}

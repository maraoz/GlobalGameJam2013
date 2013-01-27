using UnityEngine;
using System.Collections;

public class FoodCollect : MonoBehaviour {

    public ThirdPersonCamera cam;
    public ThirdPersonController con;
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
        cam.MoveAway();
        con.speed *= (growRate-1)/2+1;

        tpc.groundedDistance *= growRate;
        tpc.groundedCheckOffset *= growRate;
        glow.intensity *= growRate;
        glow.range *= growRate;

        transform.localScale *= growRate;
        foreach (ParticleEmitter pe in particles) {
            pe.minSize *= growRate;
            pe.maxSize *= growRate;
        }
    }

}

using UnityEngine;
using System.Collections;

public class FoodCollect : MonoBehaviour {

    public GameObject cover;
    public float growCover = 0.1f;
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
        } else if (collider.gameObject.tag == "Defense") {
            Destroy(collider.gameObject);
            GrowStronger();
        }
    }


    void GrowSize() {
        cam.MoveAway();
        con.speed *= (growRate - 1) / 4 + 1;

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

    void GrowStronger() {
        Color c = cover.renderer.material.color;
        c.a += growCover;
        if (c.a > 0.7f) {
            c.a = 0.5f;
        }
        cover.renderer.material.color = c;
    }

}

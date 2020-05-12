using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour {
  public float speed = 15;
  public ParticlesPool hit_particles;

  void Update () {
    transform.Translate(0,0, speed * Time.deltaTime);
  }

  void OnTriggerEnter (Collider c) {
    AttackableEnemy enemy = c.GetComponent<AttackableEnemy>();

    if (c.GetComponent<AttackableEnemy>()) {
      Destroy(gameObject);

      if (enemy.MakeDamage(1, transform.position, 1)) {
        CameraSmoothFollow.Instance.Shake(0.25f,0.1f);
        CameraSmoothFollow.Instance.Freeze(0.25f);
        hit_particles.PlayParticleAt(c.transform.position + (c.transform.position - transform.position)/2);
      }
    }
  }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gun : MonoBehaviour {
  public GameObject bulletPrototype;
  public PlayerMotion motion;
  public Cooldown cooldown;
  public bool shooting = false;
  public Sword sword;

  void OnEnable () {
    InputManager.input.WorldActions.Shoot.started += ctx => {
      cooldown.current = 0;
      shooting = true;
    };

    InputManager.input.WorldActions.Shoot.canceled += ctx => {
      shooting = false;
    };

    cooldown.onOver += Shoot;
  }

  void Update () {
    cooldown.Update();
  }

  public void Shoot () {
    if (!cooldown.IsOver || !shooting) return;

    cooldown.Reset();
    Bullet bullet = Instantiate(bulletPrototype).GetComponent<Bullet>();
    bullet.transform.forward = motion.attackDirection;
    bullet.transform.position = transform.position;
    bullet.hit_particles = sword.hit_particles;
  }
}

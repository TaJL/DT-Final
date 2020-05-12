using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FruitDropper : MonoBehaviour {
  public GameObject fruitPrototype;
  public Transform spawn;
  public Transform[] fruitTarget;
  public Tween tweener;
  public float t = 1;
  public Attackable attackable;
  public Animator animator;

  void OnEnable () {
    attackable.cooldown.onOver += SpawnFruit;
    attackable.onDamageTaken += DropFruit;
  }

  public void DropFruit () {
    GameObject fruit = Instantiate(fruitPrototype);
    fruit.transform.position = spawn.position;
    tweener.TweenTo(fruit.transform,
                    fruitTarget[Random.Range(0, fruitTarget.Length)].position, null,null);
    spawn.gameObject.SetActive(false);
    animator.SetTrigger("shake");
  }

  public void SpawnFruit () {
    spawn.gameObject.SetActive(true);
  }
}

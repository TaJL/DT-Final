using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartDialogues : MonoBehaviour {
  public Npc good;
  public Npc evil;
  public HidableGroup trees;
  public HidableGroup signals;
  public CompositeSpawner enemySpawner;
  public bool motion;
  public bool look;
  public bool attack;

  IEnumerator Start () {
    yield return new WaitForSeconds(1);
    good.Speak();
    good.onTalkingFinished += GrowTrees;
    StartCoroutine(_EvilScript());

    InputManager.input.WorldActions.Move.performed += ctx => motion = true;
    InputManager.input.WorldActions.Look.performed += ctx => {
      if (ctx.ReadValue<Vector2>().x != 0) {
        look = true;
      }
    };
    InputManager.input.WorldActions.MeleeAttack.started += ctx => attack = true;
  }

  public void GrowTrees () {
    good.onTalkingFinished -= GrowTrees;
    trees.SetVisibility(true);
  }

  IEnumerator _EvilScript () {
    yield return new WaitUntil(() => good.doneTalking); //  && motion && look);
    yield return new WaitForSeconds(5);
    evil.Speak();
    yield return new WaitUntil(() => evil.doneTalking); //  && attack);
    enemySpawner.gameObject.SetActive(true);
    enemySpawner.onFinished += HandleFinish;
  }

  public void HandleFinish () {
    StartCoroutine(_Cinematic());
    signals.SetVisibility(true);
  }

  IEnumerator _Cinematic () {
    float elapsed = 0;
    while (elapsed > 1) {
      yield return null;
    }
  }
}

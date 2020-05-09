using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerDecisions : NonPersistantSingleton<PlayerDecisions> {
  public static event System.Action<Decision, Npc> onDecisionMade;
  public static bool isActive = false;
  public Animator animator;
  public Npc target;

  public Transform decissions;

  void Awake () {
    isActive = false;
    InputManager.input.Decission.North.started +=
      ctx => { StartCoroutine(_Decide(Decision.North)); };
    InputManager.input.Decission.South.started +=
      ctx => { StartCoroutine(_Decide(Decision.South)); };
    InputManager.input.Decission.East.started +=
      ctx => { StartCoroutine(_Decide(Decision.East)); };
    InputManager.input.Decission.West.started +=
      ctx => { StartCoroutine(_Decide(Decision.West)); };
  }

  public void Activate (Npc npc) {
    animator.SetBool("visible", true);
    InputManager.input.Dialogue.Disable();
    InputManager.input.Decission.Enable();
    isActive = true;
    this.target = npc;

    foreach (Transform child in decissions) {
      Animator a = child.GetComponent<Animator>();
      if (a) {
        if (npc.availableDecisions.Get(child.name) == "") {
          child.gameObject.SetActive(false);
        } else {
          child.gameObject.SetActive(true);
          a.SetBool("selected", false);
          child.GetComponentInChildren<Text>().text =
            npc.availableDecisions.Get(child.name);
        }
      }
    }
  }

  public void Hide () {
    animator.SetBool("visible", false);
    InputManager.input.Decission.Disable();
    isActive = false;
  }

  IEnumerator _Decide (Decision decision) {
    if (target.availableDecisions.Get(decision) == "") yield break;

    InputManager.input.Decission.Disable();
    decissions.Find(decision.ToString()).GetComponent<Animator>().SetBool("selected", true);

    yield return new WaitForSeconds(0.8f);

    Hide();
    if (onDecisionMade != null)
      onDecisionMade(decision, Player.Instance.dialogues.target);
  }
}

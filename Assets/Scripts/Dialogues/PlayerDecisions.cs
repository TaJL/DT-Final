using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerDecisions : NonPersistantSingleton<PlayerDecisions> {
  public static event System.Action<Decision, Npc> onDecisionMade;
  public static bool isActive = false;
  public Animator animator;

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

  public void Activate () {
    animator.SetBool("visible", true);
    InputManager.input.Dialogue.Disable();
    InputManager.input.Decission.Enable();
    isActive = true;

    foreach (Transform child in decissions) {
      child.GetComponent<Animator>().SetBool("selected", false);
    }
  }

  public void Hide () {
    animator.SetBool("visible", false);
    InputManager.input.Decission.Disable();
    isActive = false;
  }

  IEnumerator _Decide (Decision decision) {
    InputManager.input.Decission.Disable();
    transform.Find(decision.ToString()).GetComponent<Animator>().SetBool("selected", true);

    yield return new WaitForSeconds(0.8f);

    Hide();
    if (onDecisionMade != null)
      onDecisionMade(decision, Player.Instance.dialogues.target);
  }
}

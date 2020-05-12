using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Npc : MonoBehaviour {
  public event System.Action onTalkingStarted;
  public event System.Action onTalkingFinished;
  public event System.Action<Decision> onDecisionGiven;
  public static int counter = 0;

  public AvailableDecissions availableDecisions;
  public Decision decision;
  public bool requiresDecision = true;
  public DialogueEntry[] message;
  public const float LECTURE_TIME_PER_WORD = 0.5f;
  public int current = 0;
  public GameObject actionIndicator;

  public RuntimeAnimatorController animController;
  public bool doneTalking = false;
  public bool omniscientDialogue = false;

  Coroutine _speak;

  void Awake () {
    if (omniscientDialogue) {
      InputManager.input.WorldActions.Talk.started += ctx => {
        if (current == 0) return;
        Speak();
      };
    }
  }

  public void Speak () {
    if (decision != Decision.None && current == 0) return;

    if (_speak == null) {
      _speak = StartCoroutine(_Speak());
      if (onTalkingStarted != null) onTalkingStarted();
    }
  }

  public void Stop () {
    StopAllCoroutines();
    _speak = null;
    NpcDialoguePlaceholder.Instance.SetVisibility(false);
    current = 0;

    PlayerDecisions.Instance.Hide();
    PlayerDecisions.onDecisionMade -= HandleDecision;
    if (!omniscientDialogue) {
      actionIndicator.SetActive(false);
    }
  }

  public void IndicateActiveForTalk () {
    if (!omniscientDialogue) {
      actionIndicator.SetActive(decision == Decision.None && current == 0);
    }
  }

  IEnumerator _Speak () {
    if (NpcDialoguePlaceholder.Instance.IsVisible && current >= message.Length) {
      NpcDialoguePlaceholder.Instance.SetVisibility(false);
      current = 0;
      doneTalking = true;
      if (onTalkingFinished != null) onTalkingFinished();
      yield break;
    }

    if (current == 0) {
      if (NpcDialoguePlaceholder.Instance.IsVisible) yield break;
      NpcDialoguePlaceholder.Instance.SetVisibility(true);
    }

    NpcDialoguePlaceholder.Instance.animator.runtimeAnimatorController = animController;

    yield return StartCoroutine(NpcDialoguePlaceholder.Instance.
                                _DisplayMessageLetterByLetter(message[current]));

    current++;
    _speak = null;
    if (current >= message.Length) {
      if (requiresDecision) {
        PlayerDecisions.Instance.Activate(this);
        PlayerDecisions.onDecisionMade += HandleDecision;
      }
    }
  }

  public void HandleDecision (Decision decision, Npc npc) {
    actionIndicator.SetActive(false);
    PlayerDecisions.onDecisionMade -= HandleDecision;
    this.decision = decision;
    if (onDecisionGiven != null) onDecisionGiven(decision);
    Speak();
  }
}

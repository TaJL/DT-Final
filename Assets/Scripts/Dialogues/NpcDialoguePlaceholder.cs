using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class NpcDialoguePlaceholder : NonPersistantSingleton<NpcDialoguePlaceholder> {
  public Text dialogue;
  public Animator animator;
  public Animator placeholder;
  public bool IsVisible { get => placeholder.GetBool("visible"); }
  public bool jump = false;

  void Awake () {
    InputManager.input.Dialogue.Skip.started +=
      ctx => jump = true;
  }

  public void SetVisibility (bool value) {
    placeholder.SetBool("visible", value);
    InputManager.SetActive(InputManager.input.Dialogue, value);
  }

  public void SetTalking(bool value) {
    if (animator) {
      animator.SetBool("is talking", value);
    }
  }

  public void Say (DialogueEntry entry) {
    StopAllCoroutines();
    StartCoroutine(_Say(entry));
  }

  public IEnumerator _Say (DialogueEntry entry) {
    if (!NpcDialoguePlaceholder.Instance.IsVisible) {
      NpcDialoguePlaceholder.Instance.SetVisibility(true);
    }

    yield return StartCoroutine(_DisplayMessageLetterByLetter(entry));
  }

  public IEnumerator _DisplayMessageLetterByLetter (DialogueEntry entry) {
    jump = false;
    dialogue.text = "";
    SetTalking(true);
    animator.SetTrigger(entry.emotion.ToString());

    for (int i=0; i<entry.message.Length && !jump; i++) {
      float x = 0;
      while (x < 0.025f) {
        yield return null;
        x += Time.deltaTime;
        if (jump) break;
      }

      dialogue.text += entry.message[i];
    }

    dialogue.text = entry.message;
    SetTalking(false);
  }

}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UIHp : MonoBehaviour {
  public Image image;
  public Animator animator;
  AttackablePlayer _hp;

  public void OnEnable () {
    _hp = GameObject.FindWithTag("Player").GetComponentInChildren<AttackablePlayer>();
    _hp.onDamageTaken += HandleDamage;
    _hp.onHealed += Heal;
    Heal();
    _hp.onDead += Restart;
  }

  void Reset () {
    image = GetComponent<Image>();
    animator = GetComponent<Animator>();
  }

  public void HandleDamage () {
    if ((_hp.hp - 1) == transform.GetSiblingIndex()) {
      animator.SetTrigger("hit");
    }
  }

  public void Heal () {
    animator.SetTrigger("heal");
  }

  public void Restart () {
    StartCoroutine(_Restart());
  }

  IEnumerator _Restart () {
    yield return new WaitForSeconds(2);
    SceneManager.LoadScene(gameObject.scene.name);
  }
}

using System;
using UnityEngine;
using System.Collections;
using UnityEditor;

[Serializable]
public class Tween
{
    [SerializeField] public float time = 1f;
    [SerializeField] public AnimationCurve curve = AnimationCurve.Linear(0,0,1,1);

    public void TweenTo(Transform transform, Vector3? end_position = null, Quaternion? end_rotation = null, Vector3? end_scale = null)
    {
        IEnumerator Coroutine() {
            float counter = 0;
            var start_position = transform.position;
            var start_rotation = transform.rotation;
            var start_scale = transform.localScale;
            do
            {
                counter = Mathf.Clamp01(counter + Time.deltaTime/time );
                if (end_position != null)
                    transform.position =
                        Vector3.LerpUnclamped(start_position, end_position.Value, curve.Evaluate(counter));
                if (end_rotation != null)
                    transform.rotation =
                        Quaternion.SlerpUnclamped(start_rotation, end_rotation.Value, curve.Evaluate(counter));
                if (end_scale != null)
                    transform.localScale =
                        Vector3.LerpUnclamped(start_scale, end_scale.Value, curve.Evaluate(counter));
                yield return null;
            } while (counter < 1f);
        }

        GameManager.Instance.StartCoroutine(Coroutine());
    }
}

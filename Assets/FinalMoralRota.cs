using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMoralRota : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Player>())
        {
            FinaleCountHandler.Instance.moralRota = true;
            SceneManager.LoadScene(0);
        }
    }
}

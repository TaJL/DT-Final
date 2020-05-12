using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalMaldad : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Player>())
        {
            FinaleCountHandler.Instance.balance = true;
            SceneManager.LoadScene(0);
        }
    }
}

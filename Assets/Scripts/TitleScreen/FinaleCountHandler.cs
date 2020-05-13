using UnityEngine.SceneManagement;
using UnityEngine;

public class FinaleCountHandler : MonoBehaviour
{
    public static FinaleCountHandler Instance;
    public bool moralRota = false;
    public bool balance = false;
    public bool maldad = false;

    public Enemy BossMaldad;
    public Enemy Balance;
    public Enemy BossMoralRota;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    public void FinalMaldad()
    {
        FinaleCountHandler.Instance.balance = true;
        SceneManager.LoadScene(0);
    }

    public void Balance()
    {
        FinaleCountHandler.Instance.balance = true;
        SceneManager.LoadScene(0);
    }

    public void FinalMoralRota()
    {
        FinaleCountHandler.Instance.balance = true;
        SceneManager.LoadScene(0);
    }
}

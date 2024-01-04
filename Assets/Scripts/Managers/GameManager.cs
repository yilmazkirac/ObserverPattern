using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        ObserverSignals.Instance.OnStartGame += OnStart;
    }
    private void OnStart()
    {
        SceneManager.LoadScene(1);
    }

    private void OnDisable()
    {
        ObserverSignals.Instance.OnStartGame -= OnStart;
    }
}

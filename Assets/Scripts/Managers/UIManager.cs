using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    private void Start()
    {
        _startButton.GetComponent<Button>().onClick.AddListener(() => { ObserverSignals.Instance.OnStartGame?.Invoke(); });
    }

}

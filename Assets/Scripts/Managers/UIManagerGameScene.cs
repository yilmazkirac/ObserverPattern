using UnityEngine;
using UnityEngine.UI;

public class UIManagerGameScene : MonoBehaviour
{
    [SerializeField] private Button _fireButton;
    [SerializeField] private Button _resetButton;
    private void Start()
    {
        _fireButton.GetComponent<Button>().onClick.AddListener(() => { ObserverSignals.Instance.OnFire?.Invoke();});
        _resetButton.GetComponent<Button>().onClick.AddListener(() => { ObserverSignals.Instance.OnRestartGame?.Invoke();});
    } 
}
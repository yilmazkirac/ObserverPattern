using System;
using UnityEngine;

public class ObserverSignals : MonoBehaviour
{
   public static ObserverSignals Instance;
    private void Awake()
    {
        if (Instance != null&&Instance!=this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public Action OnStartGame;
    public Action OnRestartGame;
    public Action OnFire;


}

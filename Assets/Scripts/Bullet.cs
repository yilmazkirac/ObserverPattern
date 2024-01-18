using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private STO_BulletStat _stats;
    public bool IsMove;
    private void OnEnable()
    {
        ObserverSignals.Instance.OnRestartGame += onResetTransform;
        ObserverSignals.Instance.OnFire += onFire;
    }
    private void onResetTransform()
    {
        IsMove = false;
        transform.position = _spawnPoint.position;
    }
  
    private void onFire()
    {
        IsMove = true;
    }
    private void OnDisable()
    {
        ObserverSignals.Instance.OnRestartGame -= onResetTransform;
        ObserverSignals.Instance.OnFire -= onFire;
    }
    private void Start()
    {
        onResetTransform();
    }
    private void Update()
    {
        if (IsMove)
        {
            Move();
        }
    } 
    private void Move()
    {
        transform.position += Vector3.forward*Time.deltaTime* _stats.Speed;
    } 
}

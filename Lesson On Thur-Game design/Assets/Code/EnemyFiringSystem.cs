using UnityEngine;

public class EnemyFiringSystem : BulletSystem
{
    [SerializeField, Header("Spawn Delay"), Range(0, 3)]
    private float interval = 1.5f;

    private void Awake()
    {
        //延遲重複
        InvokeRepeating("SpawnBullet", 0, interval);
    }
}

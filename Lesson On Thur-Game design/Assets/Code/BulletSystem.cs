using UnityEngine;

public class BulletSystem : MonoBehaviour
{
    [SerializeField, Header("Bullut")]
    private GameObject prefabBullut;
    [SerializeField, Header("Spawn")]
    private Transform pointSpawn;

    protected void SpawnBullet()
    {
        //生成子彈，子彈，位置
        Instantiate(prefabBullut, pointSpawn.position, pointSpawn.rotation);

    }
}

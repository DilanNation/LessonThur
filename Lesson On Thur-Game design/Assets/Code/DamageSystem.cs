using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    //nameTarget是物件名字
    [SerializeField, Header("會造成傷害的目標")]
    private string nameTarget;
    [SerializeField, Header("爆炸的東西")]
    private GameObject prefabExplosion;

    //開始，一次性
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains(nameTarget))
        {
            Instantiate(prefabExplosion, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }

    //離開，一次性
    private void OnCollisionExit2D(Collision2D collision)
    {

    }


    //持續
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
}

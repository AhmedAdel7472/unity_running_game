using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Score_Manager.instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
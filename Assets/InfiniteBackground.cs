using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{
    public Transform player;
    
    float spriteWidth;
    
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        spriteWidth = sr.bounds.size.x;
    }
    
    void Update()
    {
        if(player.position.x > transform.position.x + spriteWidth)
        {
            transform.position = new Vector3(transform.position.x + spriteWidth * 3, transform.position.y, transform.position.z);
        }
        else if(player.position.x < transform.position.x - spriteWidth)
        {
            transform.position = new Vector3(transform.position.x - spriteWidth * 3, transform.position.y, transform.position.z);
        }
    }
}
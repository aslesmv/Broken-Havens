using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public int damage = 10;
    public float knockback = 5;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            // Damage or Destroy the Enemy GameObject
            Destroy(collision.gameObject);
        }
    }
}

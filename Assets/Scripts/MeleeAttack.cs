using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    private BoxCollider2D hitbox;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitbox = transform.Find("HitboxGameObjectName").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Attack activated when 'K' is pressed
        if (Input.GetKeyDown(KeyCode.K))
        {
            Invoke("ActivateHitbox", 0.2f); // Activate Hitbox after 0.2 Seconds
            Invoke("DeactivateHitbox", 0.4f); //Deactivate Hitbox after 0.4 seconds
        }
    }

    void ActivateHitbox()
    {
        hitbox.gameObject.SetActive(true);
    }

    void DeactiveHitbox()
    {
        hitbox.gameObject.SetActive(false);
    }
}

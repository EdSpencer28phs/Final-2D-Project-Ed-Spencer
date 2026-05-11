using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }

}

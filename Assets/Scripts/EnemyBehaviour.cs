using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    // Update is called once per frame
    void Update()
    {
        //slightly stolen from Unity Unlocked on YouTube
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}

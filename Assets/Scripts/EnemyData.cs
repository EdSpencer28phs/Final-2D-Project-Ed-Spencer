using UnityEngine;

public class EnemyData : MonoBehaviour
{
    public float HP;
    public bool isAlive;
    void Start()
    {
        HP = 50;
        isAlive = true;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weapon")
        {
           //Subtracts 10 HP
            HP += -50;
        }
        if(HP<=0)
        {
            isAlive = false;
        }
        if (isAlive == false)
        {
            Destroy(gameObject);
        }
    }
}

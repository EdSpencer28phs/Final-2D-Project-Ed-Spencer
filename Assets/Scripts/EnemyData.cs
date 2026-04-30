using UnityEngine;

public class EnemyData : MonoBehaviour
{
    public float HP;
    void Start()
    {
        HP = 50;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weapon")
        {
           //Subtracts 10 HP
            HP += -50;
        }
    }
}

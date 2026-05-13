using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float HP;
    public float XP;
    public Rigidbody2D rb;
    public bool isAlive;
    public PlayaMovement data;
    public float timeInLevel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 100;
        XP = 0;
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            Debug.Log("You Died :(");
            isAlive = false;
            data.ammo = 0;
        }
        timeInLevel += Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hazard")
        {
           //Subtracts 10 HP
            HP += -10;
            Debug.Log("Ouch");
        }
    }
}

using UnityEngine;
using TMPro;
public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text XpHpAndAmmoUI;
    public PlayerData player;
    public PlayaMovement movement;
    void Start()
    {
        XpHpAndAmmoUI.text = "HP:" + player.HP +  "XP:" + player.XP + "AMMO:" + movement.ammo;
    }

    // Update is called once per frame
    void Update()
    {
         XpHpAndAmmoUI.text = "HP:" + player.HP +  "\nXP:" + player.XP + "\nAMMO:" + movement.ammo + "\nTime:" + player.timeInLevel;
    }
}

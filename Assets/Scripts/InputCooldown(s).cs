using UnityEngine;

[System.Serializable]
public class InputCooldown 
{
    //Script is from chonk on youtube https://www.youtube.com/watch?v=5r6RmddoR80
    [SerializeField] private float cooldownTime;
    private float _nextFireTime;

    public bool isCoolingDown => Time.time < _nextFireTime;

    public void StartCooldown () => _nextFireTime = Time.time + cooldownTime;
}

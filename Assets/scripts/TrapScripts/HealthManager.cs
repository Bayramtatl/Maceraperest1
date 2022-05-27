using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Healthbar healthbar;
    public GameObject player;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth  <= 0)
        {
            currentHealth = 0;
            player.transform.position = spawn.position;
            currentHealth = 100;
            healthbar.UpdateHealth((float)currentHealth / (float)maxHealth);
        }
    }
    public void HurtPlayer(int damage)
    {
        currentHealth -= damage;
        healthbar.UpdateHealth((float)currentHealth / (float)maxHealth);
    }
    public int HealPlayer(int healAmount)
    {
        if(currentHealth == 100)
        {
            return 0;
        }
        currentHealth += healAmount;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthbar.UpdateHealth((float)currentHealth / (float)maxHealth);
        return 1;
    }
}

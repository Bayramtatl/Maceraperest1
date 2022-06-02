using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Healthbar healthbar;
    public GameObject player;
    public Transform spawn;
    public Text Sayac;
    int flag = 1;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Sayac.text = "Adventurer : 1";


    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth  <= 0)
        {
            flag++;
            currentHealth = 0;
            player.transform.position = spawn.position;
            currentHealth = 100;
            healthbar.UpdateHealth((float)currentHealth / (float)maxHealth);
            Sayac.text = "Adventurer : "+ flag;
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

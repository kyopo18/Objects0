using UnityEngine;
using UnityEngine.Events;
public class Health 
{
    public int currentHealth;
    public UnityEvent<int> OnHealthChanged;
    private int maxHealth;

    public void DecreaseLife(int damage)
    {
        currentHealth -= damage;
        OnHealthChanged.Invoke(currentHealth);
    }

    public void DecreaseLife()
    {
        Debug.Log("LOST Health. CURRENT HEALTH: " + currentHealth);
        currentHealth -= 1;
        OnHealthChanged.Invoke(currentHealth);

    }

    public void DecreaseLife(int damage, float timer)
    {
        
    }

    public void IncreaseLife(int heal)
    {
        if(currentHealth + heal > maxHealth)
        {
            currentHealth  = maxHealth;
        }
        else
        {
            currentHealth += heal;
        }

    }

    public Health(int maxHealth)
    {
        currentHealth = maxHealth;
        this.maxHealth = maxHealth;
        OnHealthChanged = new UnityEvent<int>();
    }

    public Health()
    {
    }
}

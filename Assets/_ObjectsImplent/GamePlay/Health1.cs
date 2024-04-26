using UnityEngine;
using UnityEngine.Events;
public class Health1 
{
    public int currentHealth;
    public UnityEvent<int> OnHealthChanged;

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

    public void IncreaseLife()
    {

    }

    public Health1(int maxHealth)
    {
        currentHealth = maxHealth;
        OnHealthChanged = new UnityEvent<int>();
    }

    public Health1()
    {
    }
}

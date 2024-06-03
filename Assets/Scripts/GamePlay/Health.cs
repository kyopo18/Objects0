using UnityEngine;
using UnityEngine.Events;
public class Health 
{
    public int currentHealth;
    public UnityEvent<int> OnHealthChanged;
    public UnityEvent<int> OnShieldChanged;
    private int maxHealth;
    private int shieldAmount = 0;
    private int shieldAmountMax;

    public void DecreaseLife(int damage)
    {
        if(shieldAmount > 0)
        {
            damage = ReduceShieldAndDamage(damage);
        }
        currentHealth -= damage;
        OnHealthChanged.Invoke(currentHealth);
    }

    private int ReduceShieldAndDamage(int damage)
    {
        // Reduces both damage and shield
        int minValue = Mathf.Min(shieldAmountMax, damage);
        damage -= minValue;
        shieldAmount -= minValue;
        OnShieldChanged.Invoke(shieldAmount);
        return damage;
    }

    public void DecreaseLife()
    {
        int damage = 1;
        if(shieldAmount > 0)
        {
            damage = ReduceShieldAndDamage(damage);
        }
        Debug.Log("LOST Health. CURRENT HEALTH: " + currentHealth);
        currentHealth -= damage;
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
        OnHealthChanged.Invoke(currentHealth);

    }
    public void AddShield(int shieldAmount)
    {
        if(this.shieldAmount + shieldAmount > shieldAmountMax)
        {
            shieldAmount = shieldAmountMax;
        }
        else
        {
            this.shieldAmount += shieldAmount;
        }
        OnShieldChanged.Invoke(shieldAmount);
    }

    public Health(int maxHealth)
    {
        currentHealth = maxHealth;
        this.maxHealth = maxHealth;
        shieldAmountMax = currentHealth/10;
        OnHealthChanged = new UnityEvent<int>();
    }

    public Health()
    {
    }
}

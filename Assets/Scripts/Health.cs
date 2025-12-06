using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public GameObject DeathVFX;
    
    private int _currentHealth;

    private void Awake()
    {
        _currentHealth = MaxHealth;
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        if (_currentHealth <= 0)
        {
            Instantiate(DeathVFX, transform.position, DeathVFX.transform.rotation);
            Destroy(this.gameObject);
        }
    }

    public int GetHealth()
    {
        return _currentHealth;
    }
}

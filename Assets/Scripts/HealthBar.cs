using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public GameObject Target;
    public Slider SliderBar;

    private Health _health;

    private void Start()
    {
        _health = Target.GetComponent<Health>();
        SliderBar.maxValue = _health.MaxHealth;
    }

    private void Update()
    {
        SliderBar.value = _health.GetHealth();
    }
}

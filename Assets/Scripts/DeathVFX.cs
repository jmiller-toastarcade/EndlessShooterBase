using UnityEngine;

public class DeathVFX : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 0.5f);
    }
}

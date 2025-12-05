using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    public float RotationSpeed = 90.0f;
    public string TagName;
    public float LifeTime = 2.0f;

    private void Start()
    {
        Destroy(this.gameObject, LifeTime);
    }

    private void Update()
    {
        // move
        transform.Translate(Vector2.down * (MoveSpeed * Time.deltaTime), Space.World);
    
        // spin
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime, Space.World);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagName))
        {
            Destroy(this.gameObject);
        }
    }
}

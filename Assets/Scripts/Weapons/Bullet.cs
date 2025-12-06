using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed = 10.0f;
    public string TagName;
    public float LifeTime = 2.0f;
    public int Damage;

    private void Start()
    {
        Destroy(this.gameObject, LifeTime);
    }

    private void Update()
    {
        transform.Translate(transform.up * (BulletSpeed * Time.deltaTime), Space.World);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(TagName))
        {
            var health = other.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(Damage);
            }
            Destroy(this.gameObject);
        }
    }
}

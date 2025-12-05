using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed = 10.0f;
    public string TagName;
    public float LifeTime = 2.0f;

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
            Destroy(this.gameObject);
        }
    }
}

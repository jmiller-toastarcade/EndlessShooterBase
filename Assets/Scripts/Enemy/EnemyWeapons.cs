using System;
using UnityEngine;
using System.Collections;

public class EnemyWeapons : MonoBehaviour
{
    public GameObject WeaponPrefab;
    public Transform FirePoint;
    public float FireRate;
    
    private Coroutine _fireRoutine;
    
    private void Start()
    {
        StartShooting();
    }

    private void StartShooting()
    {
        _fireRoutine = StartCoroutine(nameof(ShootLoop));
    }

    private IEnumerator ShootLoop()
    {
        while (true)
        {
            Instantiate(WeaponPrefab, FirePoint.position, FirePoint.rotation);
            yield return new WaitForSeconds(FireRate);
        }
    }
}

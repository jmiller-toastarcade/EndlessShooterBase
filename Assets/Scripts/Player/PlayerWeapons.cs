using UnityEngine;
using System.Collections;

public class PlayerWeapons : MonoBehaviour
{
    public GameObject WeaponPrefab;
    public Transform FirePoint;
    public float FireRate;

    private PlayerInputHandler _inputs;
    private Coroutine _fireRoutine;

    private void Start()
    {
        _inputs = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        StartShooting();
        StopShooting();
    }

    private void StartShooting()
    {
        if (_inputs.IsShooting && _fireRoutine == null)
        {
            _fireRoutine = StartCoroutine(nameof(ShootLoop));
        }
    }

    private void StopShooting()
    {
        if (!_inputs.IsShooting && _fireRoutine != null)
        {
            StopCoroutine(_fireRoutine);
            _fireRoutine = null;
        }
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

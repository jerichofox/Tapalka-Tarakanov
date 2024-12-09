using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public int damage = 1;
    public float cooldownTime = 5f;
    bool damaged = false;

    public HealthManager healthManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!damaged && (collision.CompareTag("Enemy")))
        {
            ApplyDamage(damage);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!damaged && (collision.gameObject.CompareTag("Enemy")))
        {
            ApplyDamage(damage);
        }
    }

    void ApplyDamage(int amount)
    {
        if (!damaged)
        {
            healthManager.TakeDamage(amount);
            damaged = true;
            StartCoroutine(CooldownTimer());
        }
    }

    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(cooldownTime);
        damaged = false;
    }
}

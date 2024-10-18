/*
 *  Author: ariel oliveira [o.arielg@gmail.com]
 */

using UnityEngine;

public class HealthBarHUDTester : MonoBehaviour
{
    public void AddHealth()
    {
        MyPlayerStats.Instance.AddHealth();
    }

    public void Heal(float health)
    {
        MyPlayerStats.Instance.Heal(health);
    }

    public void Hurt(float dmg)
    {
        MyPlayerStats.Instance.TakeDamage(dmg);
    }
}

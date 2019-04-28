using UnityEngine;

public class BaseWeapon : MonoBehaviour
{ 
    float lastDamageTime = 0;
    float currentTime = 0;

    protected void ApplyDamage(Collider bot)
    {
        currentTime = Time.realtimeSinceStartup;
        bool enoughTimeHasPassed = currentTime - lastDamageTime > 1;
        if (enoughTimeHasPassed)
        {
            ScoreTracker scoreTracker = bot.GetComponent<ScoreTracker>();

            int damage = 10;
            scoreTracker.UpdateHealth(damage);

            lastDamageTime = Time.realtimeSinceStartup;
        }
    }
}

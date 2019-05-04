using UnityEngine;

public class BaseWeapon : MonoBehaviour
{ 
    float lastDamageTime = 0f;
    float currentTime = 0f;

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

    protected bool IsOpponentHit(GameObject me, Collider other)
    {
        if (other.transform.tag == null || other.transform.tag == "Untagged") return false;

        char thisPlayerNumber = me.transform.parent.tag[6];
        char colliderPlayerNumber = other.transform.tag[6];

        bool isOtherPlayerHit = thisPlayerNumber != colliderPlayerNumber;
        return isOtherPlayerHit;
    }
}

using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public float healthamount = 50f;
    public PlayerHealth Object;


    public void Damage(float taken)
    {
        healthamount -= taken;
        if (healthamount <= 0f)
        {
            Dead();
        }
    }

    void Dead()
    {
        Destroy(gameObject);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the collider");
            Debug.Log("Fill amount = " + Object.Foreground.fillAmount);
            if (Object.health > 0)
            {
                Object.health -= 5.0f * Time.deltaTime;
            }


        }

        if (other.CompareTag("Family"))
        {
            Debug.Log("Family entered the collider");
            if (Object.health > 0)
            {
                Object.health -= 5.0f * Time.deltaTime;
            }
        }
    }
}






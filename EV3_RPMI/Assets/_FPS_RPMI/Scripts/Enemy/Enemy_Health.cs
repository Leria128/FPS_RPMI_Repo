using UnityEngine;

public class Enemy_Health : MonoBehaviour
{

    [Header("Health System Configuration")]
    [SerializeField] int Health;
    [SerializeField] int MaxHealth;

    [Header("Feedback Configuration")]
    [SerializeField] Material DamagedMaterial;
    [SerializeField] MeshRenderer EnemyRender;
    [SerializeField] GameObject deathVhx;
    Material baseMat;

    private void Awake()
    {
        Health = MaxHealth;
        baseMat = EnemyRender.material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Health = 0;
            deathVhx.SetActive(true);
            deathVhx.transform.position = transform.position;
            gameObject.SetActive(false);
            
        }
    }

    public void TakeDamage(int damage) 
    { 
     Health -= damage;
     EnemyRender.material = DamagedMaterial;
     Invoke(nameof(ResetEnemyMat), 0.1f);
    }

    void ResetEnemyMat() 
    { 
     EnemyRender.material = baseMat;
    }

}

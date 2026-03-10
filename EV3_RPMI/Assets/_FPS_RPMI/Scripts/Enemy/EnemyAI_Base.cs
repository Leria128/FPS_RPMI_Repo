using UnityEngine;
using UnityEngine.AI;

public class EnemyAI_Base : MonoBehaviour
{
    #region General Variables
    [Header("AI Configuration")]
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform target;
    [SerializeField] LayerMask targetLayer;
    [SerializeField] LayerMask groundLayer;

    [Header("Patroling Stats")]
    [SerializeField] float walkPointRange = 10f;
    Vector3 walkPoint;
    bool walkPointSet;

    [Header("Attack Stats")]
    [SerializeField] float timeBetweenAttacks = 1.0f;
    [SerializeField] GameObject projectile;
    [SerializeField] Transform shootPoint;
    [SerializeField] float shootSpeedY;
    [SerializeField] float shootSpeedZ = 10f;
    bool alreadyAttacked;

    [Header("States & Detection")]
    [SerializeField] float sightRange = 8f;
    [SerializeField] float attackRange = 2f;
    [SerializeField] bool targetInSightRange;
    [SerializeField] bool targetInAttackRange;

    [Header("Stuck Detection")]
    [SerializeField] float stuckCheckTime = 2f;
    [SerializeField] float stuckThreshold = 0.1f;
    [SerializeField] float maxStuckDuration = 3f;

    float stuckTimer;
    float lastCheckedTime;
    Vector3 lastPositio;
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

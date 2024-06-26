using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;
    
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) // if this enemy has a target to follow...
        {
            agent.SetDestination(target.position); //set that targets current position as enemys position
        }
    }
    
    private void ONTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) //if the object this enemy just hit is the player
        {
            //Despawn the player, and tell the GameManager to reser the current level
            Destroy(other.gameObject);
            GameManager.Instance.GameOver();
        }
    }
}

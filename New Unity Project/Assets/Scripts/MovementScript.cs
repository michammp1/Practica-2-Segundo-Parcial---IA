using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    
    UnityEngine.AI.NavMeshAgent agentedeNavegacion;
    public GameObject destino;

    void Start()
    {
        agentedeNavegacion = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agentedeNavegacion.SetDestination(destino.transform.position);
    }

    void Update()
    {

    }
}

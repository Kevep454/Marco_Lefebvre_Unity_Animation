using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IA_Perception : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject pawn;
    [SerializeField] private float distance;
    private Vector3 direction;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CheckDistance()
    {
        direction = player.transform.position - pawn.transform.position;
        direction = direction.normalized;
        direction = direction * distance;

        RaycastHit hit;
        if (Physics.Raycast(pawn.transform.position, direction,out hit, distance))
        {
            if (hit.collider.gameObject.GetComponent<PlayerController>())
            {
                pawn.GetComponentInChildren<IA_Controller>().playerNear = true;
            }
            else
            {
                pawn.GetComponentInChildren<IA_Controller>().playerNear = false;
            }
        }
        else
        {
            pawn.GetComponentInChildren<IA_Controller>().playerNear = false;
        }
    }
}

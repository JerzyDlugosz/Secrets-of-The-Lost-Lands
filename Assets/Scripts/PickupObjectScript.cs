using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupObjectScript : MonoBehaviour
{
    private Transform player;
    private Transform parent;
    private PlayerRaycast playerRaycast;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        parent = this.transform.parent;
        playerRaycast = player.GetComponent<PlayerRaycast>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerRaycast.EnableRaycast(parent);
        }
    }

    private void OnTriggerStay(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerRaycast.DisableRaycast(parent);
        }
    }
}

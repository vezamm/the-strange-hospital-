using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public Transform respawnpoint;
    public GameObject Player;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag=="Player"&& Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("tped");
            Player.transform.position=respawnpoint.position;
        }
    }

}

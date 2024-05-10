using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public Camera cam;
    public GameObject pressE;
    public item _item;
    public Uiscripts _uiscripts;
    
    // Start is called before the first frame update
    void Start()
    {
        //cam = Camera.main;    
    }

    // Update is called once per frame
    void Update()
    {
        raycasting();
    }
    public void raycasting()
    {
        RaycastHit hitinfo;
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        //Vector3 forwardDirection=transform.forward;
        //Debug.DrawRay(transform.position,forwardDirection*2, Color.red) ;
        if(Physics.Raycast(ray, out hitinfo,2))
        {
            if(hitinfo.collider.CompareTag("MorgueDoor"))
            {
                   //Debug.DrawRay(transform.position,forwardDirection*2, Color.green) ;
                pressE.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E)) 
                {
                    DoorAnimation _doorAnimation = hitinfo.collider.GetComponent<DoorAnimation>();
                    _doorAnimation.Open();
                } 
               
            }else pressE.SetActive(false);
            if (hitinfo.collider.CompareTag("items"))
            {
                //Debug.DrawRay(transform.position, forwardDirection*2, Color.green) ;
                pressE.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    itemPickup _itempickup = hitinfo.collider.GetComponent<itemPickup>();
                    _itempickup.Pickup();
                }
            }
            if (hitinfo.collider.CompareTag("morguedoorlocked"))
            {
                pressE.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E) )
                {
                    _uiscripts.openinventory();
                }
            }
        }

    }
}

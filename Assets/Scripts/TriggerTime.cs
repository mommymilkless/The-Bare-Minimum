using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTime : MonoBehaviour
{
    public GameObject tutorialZone;

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name=="TutorialZone")
        {
            //Debug.Log("You have triggered the tutorial");
            
            
            Destroy(tutorialZone);
            //Debug.Log("The tutorial zone has been deleted");
        }
    }
}

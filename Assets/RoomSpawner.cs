using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    // 1 --> need bottom door
    // 2 --> need left door
    // 3 --> need right door
    // 4 --> need top door

    private RoomTemplates templates;
    private int rand;
    
    void Start(){
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
    }

    void Update()
    
        if(openingDirection == 1){
            // needs to spawn BOTTOM door
        rand = Random.Range(0, templates.bottomRooms.Length);    
        Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
        } else if (openingDirection == 2){
    // needs to spawn LEFT door
    Instantiate(templates.leftRooms[rand], transform.position, templates.leftRoom[rand].transform.rotation);
} else if (openingDirection == 3){
    // needs to spawn RIGHT door
    Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
} else if (openingDirection == 4){
    // needs to spawn TOP door
    Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
}
     }
}

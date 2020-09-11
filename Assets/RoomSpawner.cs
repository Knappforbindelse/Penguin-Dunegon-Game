using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class RoomSpawner : MonoBehaviour
{
    private bool Spawned = false;
    public int openingDirection;
    // 1 --> need bottom door
    // 2 --> need left door
    // 3 --> need right door
    // 4 --> need top door

    private int rand;
    private RoomTemplates templates;
    


    void Start()

    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Invoke("Spawn", 0.1f);
    }

    void Spawn()
    { 
        if (Spawned == false)
        {
            if (openingDirection == 1)
            {
                //Need to spawn BOTTOM
                rand = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                //Need to spawn LEFT
                rand = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
            }
            else if (openingDirection == 3)
            {
                //Need to spawn RIGHT
                rand = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
            }
            else if (openingDirection == 4)
            {
                //Need to spawn TOP
                rand = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
            }
            Spawned = true;
        }
    }
    void onTriggerEnter2D(Collider2D collider2DBody)
    {
        if (collider2DBody.CompareTag("SpawnPoint"))
        {
            Destroy(gameObject);
        }
    }
}


        
      
   


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is a singleton
public class SpawnManager : MonoBehaviour
{
  //Crate an instance, must always be static 
  private static SpawnManager _instance;

    //Property that let's other scripts access this class
    public static SpawnManager Instance
    {
        get
        {
         //Return the instance only if the script is not null
         if( _instance == null )
            {
                Debug.LogError("The Spawn Manager is null!");
            }
         return _instance;
        }
    }
    //As soon as the script is called upon, instance is assigned 
    private void Awake()
    {
        _instance = this;
    }

    public void StartSpawning()
    {
        Debug.Log("You are spawning enemies");
    }
}



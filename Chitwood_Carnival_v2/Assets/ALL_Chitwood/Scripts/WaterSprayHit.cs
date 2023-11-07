using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using Random = UnityEngine.Random;



public class WaterSprayHit : MonoBehaviour
{
    public List<GameObject> gameObjectsList;
    private WaterGunGame waterGunGame;

    private static int sprayCollisionCount = 0;
    private static int activationIndex = 0;


    private void Start()
    {

        WaterGunGame waterGunGame = FindObjectOfType<WaterGunGame>();
        if (waterGunGame != null)
        {
            int value = waterGunGame.currentAttempt2;
            Debug.Log("Attempt: " + value);

            if (value < 1) // if current attempt is less than 1 deactivate all objects
            {
                DeactivateAllObjects();  
                Debug.Log("deactivate water level");

            }
        }
    }



    // void ParticleEffect(List<ParticleSystem> listPart, ParticleSystem destructionEffect)


    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("target"))
        {
            sprayCollisionCount++;
            Debug.Log("Spray Collision: " + sprayCollisionCount);

            // Activate the next objects in the list.
          ///  ActivateNextOne(gameObjectsList, activationIndex);
            gameObjectsList[activationIndex].SetActive(true);

            activationIndex++;
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }




    void DeactivateAllObjects()
    {
        foreach (var obj in gameObjectsList)
        {
            obj.SetActive(false);
        }
    }
 
}

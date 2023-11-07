using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using Random = UnityEngine.Random;



public class HitBalloonDestroy : MonoBehaviour
{
    public List<GameObject> gameObjectsList;
    private BalloonGame balloonGame;

    public ParticleSystem destructionEffect;
    private static int balloonCollisionCount = 0;
    private static int activationIndex = 0;


    private void Start()
    {

        BalloonGame balloonGame = FindObjectOfType<BalloonGame>();
        if (balloonGame != null)
        {
            int value = balloonGame.currentAttempt;
            Debug.Log("Attempt: " + value);

            if (value < 1) // if current attempt is less than 1 deactivate all objects
            {
                DeactivateAllObjects();  // deactivate the flowers
                Debug.Log("deactivate flowers");

            }
        }
    }
   


    // void ParticleEffect(List<ParticleSystem> listPart, ParticleSystem destructionEffect)


void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("balloon"))
        {
            destructionEffect.Play();
            Destroy(collision.gameObject);
            Debug.Log("Balloon destroyed");

            balloonCollisionCount++;
            Debug.Log("Balloon Collision Count: " + balloonCollisionCount);

            // Activate the next two objects in the list.
            ActivateNextTwo(gameObjectsList, activationIndex);
            activationIndex += 2;
        }
    }

    void ActivateNextTwo(List<GameObject> list, int startIndex)
    {
        int n = list.Count;

        for (int i = startIndex; i < startIndex + 2 && i < n; i++)
        {
            list[i].SetActive(true);
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








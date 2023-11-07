using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using Unity.Mathematics;
using Unity.VisualScripting;
using System;
using System.IO;
using System.Text;
using UnityEditor;
using System.Xml.Linq;

public class BalloonGame : MonoBehaviour
{

    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private float arrowForce = 1000f;
    [SerializeField] private Vector3 arrowOffset;


    public GameObject platform;


    public int currentAttempt;
    public int attemptLimit = 7;
    private Collider col;
    private bool playerPlatformCol;
    void Start()
    {
        //  StartCoroutine(trialRun()); //Start running out trial
        arrowPrefab.SetActive(false);
    }
    //  public TMP_Text attemptText;

    // Update is called once per frame

    private void OnCollisionEnter(Collision col)
    {
        // if (col.gameObject.CompareTag("Player")
        if (col.gameObject == platform)

        {
            playerPlatformCol = true;
            Debug.Log("collided with platform");
            arrowPrefab.SetActive(true);


        }
        //  else
        //{
        //  playerPlatformCol = false;
        //}
    }
   // IEnumerator trialRun()
    void Update()
      //  bool running = true;
       // while (running)
        {
            if (playerPlatformCol == true && Input.GetMouseButtonDown(1))
            {
             //   player = GameObject.FindGameObjectWithTag("Player");
            GameObject newArrow = Instantiate(arrowPrefab, Camera.main.transform);
            newArrow.transform.position += arrowOffset;
            newArrow.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * arrowForce);
            (++currentAttempt).ToString();


            if (currentAttempt >= 8)
                {
                    newArrow.SetActive(false);
                }
            }
         //   yield return null;
        }
    }
           
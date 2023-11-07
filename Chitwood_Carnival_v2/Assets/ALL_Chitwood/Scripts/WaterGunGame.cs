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

public class WaterGunGame : MonoBehaviour
{

    [SerializeField] private GameObject waterSprayPrefab;
    [SerializeField] private float waterSprayForce = 1000f;
    [SerializeField] private Vector3 waterSprayOffset;



    public GameObject platform;


    public int currentAttempt2;
    public int attemptLimit = 10;
    private Collider collide;
    private bool playerPlatform2Col;
    void Start()
    {
        //  StartCoroutine(trialRun()); //Start running out trial
        waterSprayPrefab.SetActive(false);
    }
    //  public TMP_Text attemptText;

    // Update is called once per frame

    private void OnCollisionEnter(Collision collide)
    {
        // if (col.gameObject.CompareTag("Player")
        if (collide.gameObject == platform)

        {
            playerPlatform2Col = true;
            Debug.Log("collided with platform");
            waterSprayPrefab.SetActive(true);


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
        if (playerPlatform2Col == true && Input.GetMouseButtonDown(1))
        {
            //   player = GameObject.FindGameObjectWithTag("Player");
            GameObject newSpray = Instantiate(waterSprayPrefab, Camera.main.transform);
            newSpray.transform.position += waterSprayOffset;
            newSpray.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * waterSprayForce);
            (++currentAttempt2).ToString();



            if (currentAttempt2 >= 11)
            {
                newSpray.SetActive(false);
            }
        }
        //   yield return null;
    }
}


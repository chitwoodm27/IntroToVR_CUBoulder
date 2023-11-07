using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using Unity.VisualScripting.FullSerializer;
using Unity.VisualScripting;
using System.Runtime.InteropServices;
using UnityEngine.Experimental.XR.Interaction;
using UnityEngine.UI;
using UnityEngine.UIElements;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;

public class PlayerTeleporter : MonoBehaviour
{
    public Vector3 place;
    public Vector3 placeBalloonGame;
    public Vector3 placeWaterBallGame;
    public Vector3 placeRestart;



    public RaycastHit _Hit;

    private float y = 1.5f;
    private float x = -1.5f;
    private float z = 21f;

    private float y2 = 1.5f;
    private float x2 = 1.15f;
    private float z2 = 37.21f;

    private float y3 = 1.5f;
    private float x3 = -7.2f;
    private float z3 = 10.6f;




    private float cameraRotationSpeed = 2f;
    private float cameraPitch = 0f;

    public void Update()
    {
        // Camera rotation based on mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the camera
        transform.Rotate(Vector3.up * mouseX * cameraRotationSpeed);
        cameraPitch -= mouseY * cameraRotationSpeed;
        cameraPitch = Mathf.Clamp(cameraPitch, -90f, 90f);
        Camera.main.transform.localRotation = Quaternion.Euler(cameraPitch, 0f, 0f);


    
        

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out _Hit))
            {
                if (_Hit.transform.tag == "terrain")
                {
                    place = new Vector3(_Hit.point.x, y, _Hit.point.z);

                    if (Input.GetMouseButtonDown(0))
                    {
                        this.gameObject.transform.position = place;
                        Debug.Log("terrain");

                    }


                }

                else

                {

                    if (_Hit.transform.tag == "platform1" && Input.GetMouseButtonDown(0))

                    {
                        placeBalloonGame = new Vector3(x, y, z);
                        this.gameObject.transform.position = placeBalloonGame;
                        Debug.Log("Platform1");

                    }
                    if (_Hit.transform.tag == "platform2" && Input.GetMouseButtonDown(0))

                    {
                        placeWaterBallGame = new Vector3(x2, y2, z2);
                        this.gameObject.transform.position = placeWaterBallGame;
                        Debug.Log("Platform2");

                    }
                    if (_Hit.transform.tag == "platform3" && Input.GetMouseButtonDown(0))

                    {
                        placeWaterBallGame = new Vector3(x3, y3, z3);
                        this.gameObject.transform.position = placeRestart;
                        Debug.Log("Platform3");
                        Debug.Log("Restart Game");
                        // Reload the current scene to restart the game.
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                    }
                }

            


        }


    }
}


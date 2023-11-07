using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class BalloonGameController : MonoBehaviour
{

    private GameObject arrowPrefab;
    private float arrowForce = 1000f;
    private Vector3 arrowOffset;
    public Vector3 place;
    public RaycastHit _Hit;
    private float y = 1.5f;


    public int currentAttempt;
    public int attemptLimit = 3;


    // Start is called before the first frame update
    void Start()
    {

    }



    void StartBalloonGame()
    {

   
        

    }
}
          /*
            }
            if (Input.GetKey("enter"))

            {
                GameObject newArrow = Instantiate(arrowPrefab, Camera.main.transform);
                newArrow.transform.position += arrowOffset;
                newArrow.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * arrowForce);
                //  (++currentAttempt).ToString();
                //  attemptText.text = currentAttempt.ToString();


                if (currentAttempt >= 4)
                {
                    //    attemptText.text = attemptLimit.ToString();
                    newArrow.SetActive(false);
                    return;
                }

            }
        }       
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}*/

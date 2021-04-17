using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject redCube;
    private ARRaycastManager arraycastmanager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        arraycastmanager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase==TouchPhase.Began)
            {
                if(arraycastmanager.Raycast(touch.position,hits,TrackableType.PlaneWithinPolygon))
                {
                    Pose hitpose = hits[0].pose;
                    Instantiate(redCube, hitpose.position, hitpose.rotation);
                }
            }
        }
    }
}

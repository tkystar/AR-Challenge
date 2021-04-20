using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MFTManager : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;
    public Button btn;
    Animation leftAnimation;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(DoorOpen);
        leftAnimation = leftDoor.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DoorOpen()
    {
        leftAnimation.Play();
    }
}

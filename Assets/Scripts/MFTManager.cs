using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MFTManager : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;
    public Button btn;
    public GameObject[] pointLight;
    Animation leftAnimation;
    Animation rightAnimation;
    private Light pointlight;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(DoorOpen);
        leftAnimation = leftDoor.GetComponent<Animation>();
        rightAnimation = rightDoor.GetComponent<Animation>();

        for (int i = 0; i < pointLight.Length; i++)
        {
            pointLight[i].GetComponent<Light>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DoorOpen()
    {
        leftAnimation.Play();
        rightAnimation.Play();
        Debug.Log("#");
        StartCoroutine("spotlighton");
        
    }

    IEnumerator spotlighton()
    {
        yield return new WaitForSeconds(2.5f);
        Debug.Log("F");

        for (int i = 0; i < pointLight.Length; i++)
        {
            pointLight[i].GetComponent<Light>().enabled = true;
        }
        

    }
}

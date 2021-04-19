using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShhot : MonoBehaviour
{
    public GameObject Cam;
    public GameObject BulletPrefab;
    private GameObject bullet;    
    Vector3 force;
    [SerializeField] private float speed = 1000;
    public Color[] color;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                bullet = Instantiate(BulletPrefab, Cam.GetComponent<Transform>().position, Quaternion.identity);
                force = Cam.transform.forward * speed;
                bullet.GetComponent<Rigidbody>().AddForce(force);
                var renderer = bullet.GetComponent<Renderer>();
                renderer.material.color = color[Random.Range(0, 4)];
            }


        }
        /*
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("!");
            bullet = Instantiate(BulletPrefab, Cam.GetComponent<Transform>().position, Quaternion.identity);
            force = Cam.transform.forward * speed;
            bullet.GetComponent<Rigidbody>().AddForce(force);
            var renderer=bullet.GetComponent<Renderer>();
            renderer.material.color = color[Random.Range(0, 4)];


        }
        */
    }
}
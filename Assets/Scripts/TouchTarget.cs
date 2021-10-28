using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchTarget : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private GameObject myGameobject;

    [SerializeField]
    private Text debug;

    private float delay = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        debug.text = "Rien";
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            debug.text = "coucou";
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            debug.text = "x: " + touchPosition.x.ToString() + " y: " + touchPosition.y.ToString() + " z: " + touchPosition.z.ToString();
            delay = 5.0f;
            GameObject instance;
            instance = Instantiate(myGameobject, touchPosition, Quaternion.identity);
            instance.transform.Translate(touchPosition);
            instance.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 50.0f, 100.0f));
        }//

        //if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        //{
        //    //debug.text = "coucou";
        //    Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        //    debug.text = "x: " + touchPosition.x.ToString() + " y: " + touchPosition.y.ToString() + " z: " + touchPosition.z.ToString(); 
        //    delay = 5.0f;
        //    GameObject instance;
        //    instance = Instantiate(myGameobject, touchPosition, Quaternion.identity);
        //    instance.transform.Translate(touchPosition);
        //    instance.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 50.0f, 100.0f));

        //}
        if (delay > 0)
            delay -= Time.deltaTime;
        else
            debug.text = "rien";
    }
}

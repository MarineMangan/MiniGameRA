using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectilesInteractor : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            if(TouchTarget.GetCounter() < 5)
            {
                TouchTarget.Setcounter(TouchTarget.GetCounter() + 1);
                if (TouchTarget.GetCounter() != 5)
                    TouchTarget.SetIsMovable(true);
                Destroy(gameObject);
            }
            if(TouchTarget.GetCounter() == 5)
            {

                //Destroy(collision.gameObject);
            }
        }
    }


    

}

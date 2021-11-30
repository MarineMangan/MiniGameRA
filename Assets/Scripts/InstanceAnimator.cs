using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(Vector3.right, 90.0f);
        Destroy(gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward, 500 * Time.deltaTime);
    }
}

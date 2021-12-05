using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, 500 * Time.deltaTime);
    }
}

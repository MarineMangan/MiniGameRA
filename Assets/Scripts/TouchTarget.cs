using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchTarget : MonoBehaviour
{
    [SerializeField]
    private Transform m_target;

    [SerializeField]
    private GameObject m_projectile;

    [SerializeField]
    private Transform m_arCamera;

    private float m_speed;

    [SerializeField]
    private Text debugText;

    private static int m_counter;
    private static bool m_isMovable;

    // Start is called before the first frame update
    void Start()
    {
        m_speed = 20000;
        m_counter = 0;
        m_isMovable = false;

        m_target.LookAt(transform);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            
            if(m_counter < 5)
            {
                GameObject instance = Instantiate(m_projectile, m_arCamera.position, m_arCamera.rotation);
                instance.GetComponent<Rigidbody>().AddForce(m_arCamera.forward * m_speed * Time.deltaTime);
            }
        }
        debugText.text = m_counter.ToString();

        if(m_isMovable)
        {
            MoveTarget();
            m_isMovable = false;
        }
    }

    public void MoveTarget()
    {
        Vector3 targetPosition = new Vector3(0.0f, 0.0f, 0.0f);

        targetPosition.x = Random.Range(-1.0f, 1.0f);
        targetPosition.y = Random.Range(-1.0f, 1.0f);
        targetPosition.z = Random.Range(-1.0f, 1.0f);

        m_target.position = targetPosition;
    }

    public void SetTargetPosition(Vector3 position)
    {
        m_target.position = position;
    }
    public static int GetCounter()
    {
        return m_counter;
    }

    public static void Setcounter(int counter)
    {
        m_counter = counter;
    }

    public static void SetIsMovable(bool isMovable)
    {
        m_isMovable = isMovable;
    }

}

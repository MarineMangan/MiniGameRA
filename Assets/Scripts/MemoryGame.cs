using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoryGame : MonoBehaviour
{
    private string m_firstTag;
    private bool m_firstCard;

    [SerializeField]
    private GameObject m_green1;
    
    [SerializeField]
    private GameObject m_green2;
    
    [SerializeField]
    private GameObject m_red1;
    
    [SerializeField]
    private GameObject m_red2;


    [SerializeField]
    private Text debugText;

    // Start is called before the first frame update
    void Start()
    {
        m_firstTag = "";
        m_firstCard = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Green1"))
                {
                    if (!m_firstCard)
                    {
                        m_green1.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                        //debugText.text = m_firstTag;
                    }
                    else
                    {
                        if (m_firstTag == "Green2")
                        {
                            Destroy(m_green1);
                            Destroy(m_green2);
                            m_firstCard = false;
                            //debugText.text = "Bonjour";
                        }
                        else if (m_firstTag == "Green1")
                        {
                            //
                           // debugText.text = "Salut";
                        }
                        else
                        {
                            m_green1.transform.Rotate(Vector3.forward, 180.0f);
                            if (m_firstTag == "Red2")
                                m_red2.transform.Rotate(Vector3.up, 180.0f);
                            else if (m_firstTag == "Green2")
                                m_green2.transform.Rotate(Vector3.up, 180.0f);
                            else if (m_firstTag == "Red1")
                                m_red1.transform.Rotate(Vector3.up, 180.0f);
                            m_firstCard = false;
                            //debugText.text = "Coucou";
                        }

                    }

                   

                }
                if (raycastHit.collider.CompareTag("Green2"))
                {
                    if (!m_firstCard)
                    {
                        m_green2.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                        //debugText.text = m_firstTag;
                    }
                    else
                    {
                        if (m_firstTag == "Green1")
                        {
                            Destroy(m_green2);
                            Destroy(m_green1);
                            m_firstCard = false;
                            //debugText.text = "Bonjour";
                        }
                        else if (m_firstTag == "Green2")
                        {
                            //
                            //debugText.text = "Salut";
                        }
                        else
                        {
                            m_green2.transform.Rotate(Vector3.forward, 180.0f);
                            if (m_firstTag == "Red2")
                                m_red2.transform.Rotate(Vector3.up, 180.0f);
                            else if (m_firstTag == "Green1")
                                m_green1.transform.Rotate(Vector3.up, 180.0f);
                            else if (m_firstTag == "Red1")
                                m_red1.transform.Rotate(Vector3.up, 180.0f);
                            m_firstCard = false;
                            //debugText.text = "Coucou";
                        }
                    }
                }
                if (raycastHit.collider.CompareTag("Red1"))
                {
                    if (!m_firstCard)
                    {
                        m_red1.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                        //debugText.text = m_firstTag;
                    }
                    else
                    {
                        if (m_firstTag == "Red2")
                        {
                            Destroy(m_red1);
                            Destroy(m_red2);
                            m_firstCard = false;
                            //debugText.text = "Bonjour";
                        }
                        else if (m_firstTag == "Red1")
                        {
                            //
                            //debugText.text = "Salut";
                        }
                        else
                        {
                            m_red1.transform.Rotate(Vector3.forward, 180.0f);
                            if (m_firstTag == "Red2")
                                m_red2.transform.Rotate(Vector3.up, 180.0f);
                            else if (m_firstTag == "Green1")
                                m_green1.transform.Rotate(Vector3.up, 180.0f);
                            else if (m_firstTag == "Green2")
                                m_green2.transform.Rotate(Vector3.up, 180.0f);
                            m_firstCard = false;
                            //debugText.text = "Coucou";
                        }
                    }
                }
                if (raycastHit.collider.CompareTag("Red2"))
                {
                    if (!m_firstCard)
                    {
                        m_red2.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                        //debugText.text = m_firstTag;

                    }
                    else
                    {
                        if (m_firstTag == "Red1")
                        {
                            Destroy(m_red2);
                            Destroy(m_red1);
                            m_firstCard = false;
                            //debugText.text = "Bonjour";
                        }
                        else if (m_firstTag == "Red2")
                        {
                            //
                            //debugText.text = "Salut";
                        }
                        else
                        {
                            m_red2.transform.Rotate(Vector3.forward, 180.0f);
                            if(m_firstTag == "Red1")
                                m_red1.transform.Rotate(Vector3.up, 180.0f);
                            else if(m_firstTag == "Green1")
                                m_green1.transform.Rotate(Vector3.up, 180.0f);
                            else if(m_firstTag == "Green2")
                                m_green2.transform.Rotate(Vector3.up, 180.0f);
                            m_firstCard = false;
                            //debugText.text = "Coucou";
                        }
                    }
                }
            }
        }
    }
}

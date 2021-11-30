using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MemoryGame : MonoBehaviour
{
    private string m_firstTag;
    private bool m_firstCard;
    private float m_strength;
    private uint m_foundPairs;

    [SerializeField]
    private GameObject m_green1;
    
    [SerializeField]
    private GameObject m_green2;
    
    [SerializeField]
    private GameObject m_red1;
    
    [SerializeField]
    private GameObject m_red2;

    [SerializeField]
    private GameObject m_yellow1;
    
    [SerializeField]
    private GameObject m_yellow2;
    
    [SerializeField]
    private GameObject m_blue1;
    
    [SerializeField]
    private GameObject m_blue2;

    [SerializeField]
    private GameObject m_red;

    [SerializeField]
    private GameObject m_yellow;

    [SerializeField]
    private GameObject m_blue;
    
    [SerializeField]
    private GameObject m_green;

    [SerializeField]
    private Text m_gameText;

    [SerializeField]
    private Text m_endGameText;


    [SerializeField]
    private Text debugText;

    // Start is called before the first frame update
    void Start()
    {
        m_firstTag = "";
        m_firstCard = false;
        m_strength = 1000.0f;
        m_foundPairs = 0;
        m_gameText.text = "Number of pairs found: 0";
        m_endGameText.text = "";
        InitiateCardsPosition();
    }

    // Update is called once per frame
    void Update()
    {
        //m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
        if(m_foundPairs == 4)
        {
            m_endGameText.text = "Congratulation!\nTouch the screen to\nreturn to the main menu.";
            Endgame();
        }

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
                    }
                    else
                    {
                        if (m_firstTag == "Green2")
                        {
                            m_green1.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_green1, 1.0f);
                            Destroy(m_green2, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_green, m_green1.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Green1")
                        {
                            //
                        }
                        else
                        {
                            m_green1.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_green1));
                            if (m_firstTag == "Red2")
                                StartCoroutine(TimerRotationCoroutine(m_red2));
                            else if (m_firstTag == "Red1")
                                StartCoroutine(TimerRotationCoroutine(m_red1));
                            else if (m_firstTag == "Yellow1")
                                StartCoroutine(TimerRotationCoroutine(m_yellow1));
                            else if (m_firstTag == "Yellow2")
                                StartCoroutine(TimerRotationCoroutine(m_yellow2));
                            else if (m_firstTag == "Blue1")
                                StartCoroutine(TimerRotationCoroutine(m_blue1));
                            else if (m_firstTag == "Blue2")
                                StartCoroutine(TimerRotationCoroutine(m_blue2));
                            m_firstCard = false;
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
                    }
                    else
                    {
                        if (m_firstTag == "Green1")
                        {
                            m_green2.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_green2, 1.0f);
                            Destroy(m_green1, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_green, m_green2.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Green2")
                        {
                            //
                        }
                        else
                        {
                            m_green2.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_green2));
                            if (m_firstTag == "Red2")
                                StartCoroutine(TimerRotationCoroutine(m_red2));
                            else if (m_firstTag == "Red1")
                                StartCoroutine(TimerRotationCoroutine(m_red1));
                            else if (m_firstTag == "Yellow1")
                                StartCoroutine(TimerRotationCoroutine(m_yellow1));
                            else if (m_firstTag == "Yellow2")
                                StartCoroutine(TimerRotationCoroutine(m_yellow2));
                            else if (m_firstTag == "Blue1")
                                StartCoroutine(TimerRotationCoroutine(m_blue1));
                            else if (m_firstTag == "Blue2")
                                StartCoroutine(TimerRotationCoroutine(m_blue2));
                            m_firstCard = false;
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
                    }
                    else
                    {
                        if (m_firstTag == "Red2")
                        {
                            m_red1.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_red1, 1.0f);
                            Destroy(m_red2, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_red, m_red1.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Red1")
                        {
                            //
                        }
                        else
                        {
                            m_red1.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_red1));
                            if (m_firstTag == "Green1")
                                StartCoroutine(TimerRotationCoroutine(m_green1));
                            else if (m_firstTag == "Green2")
                                StartCoroutine(TimerRotationCoroutine(m_green2));
                            else if (m_firstTag == "Yellow1")
                                StartCoroutine(TimerRotationCoroutine(m_yellow1));
                            else if (m_firstTag == "Yellow2")
                                StartCoroutine(TimerRotationCoroutine(m_yellow2));
                            else if (m_firstTag == "Blue1")
                                StartCoroutine(TimerRotationCoroutine(m_blue1));
                            else if (m_firstTag == "Blue2")
                                StartCoroutine(TimerRotationCoroutine(m_blue2));
                            m_firstCard = false;
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
                    }
                    else
                    {
                        if (m_firstTag == "Red1")
                        {
                            m_red2.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_red2, 1.0f);
                            Destroy(m_red1, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_red, m_red2.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Red2")
                        {
                            //
                        }
                        else
                        {
                            m_red2.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_red2));
                            if (m_firstTag == "Green1")
                                StartCoroutine(TimerRotationCoroutine(m_green1));
                            else if (m_firstTag == "Green2")
                                StartCoroutine(TimerRotationCoroutine(m_green2));
                            else if (m_firstTag == "Yellow1")
                                StartCoroutine(TimerRotationCoroutine(m_yellow1));
                            else if (m_firstTag == "Yellow2")
                                StartCoroutine(TimerRotationCoroutine(m_yellow2));
                            else if (m_firstTag == "Blue1")
                                StartCoroutine(TimerRotationCoroutine(m_blue1));
                            else if (m_firstTag == "Blue2")
                                StartCoroutine(TimerRotationCoroutine(m_blue2));
                            
                            m_firstCard = false;
                        }
                    }
                }

                if (raycastHit.collider.CompareTag("Yellow1"))
                {
                    
                    if (!m_firstCard)
                    {
                        m_yellow1.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                    }
                    else
                    {
                        if (m_firstTag == "Yellow2")
                        {
                            m_yellow1.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_yellow1, 1.0f);
                            Destroy(m_yellow2, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_yellow, m_yellow1.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Yellow1")
                        {
                            //
                        }
                        else
                        {
                            m_yellow1.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_yellow1));
                            if (m_firstTag == "Red1")
                                StartCoroutine(TimerRotationCoroutine(m_red1));
                            else if (m_firstTag == "Green1")
                                StartCoroutine(TimerRotationCoroutine(m_green1));
                            else if (m_firstTag == "Green2")
                                StartCoroutine(TimerRotationCoroutine(m_green2));
                            else if (m_firstTag == "Red2")
                                StartCoroutine(TimerRotationCoroutine(m_red2));
                            else if (m_firstTag == "Blue1")
                                StartCoroutine(TimerRotationCoroutine(m_blue1));
                            else if (m_firstTag == "Blue2")
                                StartCoroutine(TimerRotationCoroutine(m_blue2));
                           
                            m_firstCard = false;
                        }
                    }
                }

                if (raycastHit.collider.CompareTag("Yellow2"))
                {
                    
                    if (!m_firstCard)
                    {
                        m_yellow2.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                    }
                    else
                    {
                        if (m_firstTag == "Yellow1")
                        {
                            m_yellow2.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_yellow1, 1.0f);
                            Destroy(m_yellow2, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_yellow, m_yellow2.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Yellow2")
                        {
                            //
                        }
                        else
                        {
                            m_yellow2.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_yellow2));
                            if (m_firstTag == "Red1")
                                StartCoroutine(TimerRotationCoroutine(m_red1));
                            else if (m_firstTag == "Green1")
                                StartCoroutine(TimerRotationCoroutine(m_green1));
                            else if (m_firstTag == "Green2")
                                StartCoroutine(TimerRotationCoroutine(m_green2));
                            else if (m_firstTag == "Red2")
                                StartCoroutine(TimerRotationCoroutine(m_red2));
                            else if (m_firstTag == "Blue1")
                                StartCoroutine(TimerRotationCoroutine(m_blue1));
                            else if (m_firstTag == "Blue2")
                                StartCoroutine(TimerRotationCoroutine(m_blue2));

                            m_firstCard = false;
                        }
                    }
                }

                if (raycastHit.collider.CompareTag("Blue1"))
                {
                    
                    if (!m_firstCard)
                    {
                        m_blue1.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                    }
                    else
                    {
                        if (m_firstTag == "Blue2")
                        {
                            m_blue1.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_blue1, 1.0f);
                            Destroy(m_blue2, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_blue, m_blue1.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Blue1")
                        {
                            //
                        }
                        else
                        {
                            m_blue1.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_blue1));
                            if (m_firstTag == "Red1")
                                StartCoroutine(TimerRotationCoroutine(m_red1));
                            else if (m_firstTag == "Green1")
                                StartCoroutine(TimerRotationCoroutine(m_green1));
                            else if (m_firstTag == "Green2")
                                StartCoroutine(TimerRotationCoroutine(m_green2));
                            else if (m_firstTag == "Red2")
                                StartCoroutine(TimerRotationCoroutine(m_red2));
                            else if (m_firstTag == "Yellow1")
                                StartCoroutine(TimerRotationCoroutine(m_yellow1));
                            else if (m_firstTag == "Yellow2")
                                StartCoroutine(TimerRotationCoroutine(m_yellow2));

                            m_firstCard = false;
                        }
                    }
                }

                if (raycastHit.collider.CompareTag("Blue2"))
                {
                    
                    if (!m_firstCard)
                    {
                        m_blue2.transform.Rotate(Vector3.up, 180.0f);
                        m_firstCard = true;
                        m_firstTag = raycastHit.collider.tag;
                    }
                    else
                    {
                        if (m_firstTag == "Blue1")
                        {
                            m_blue2.transform.Rotate(Vector3.up, 180.0f);
                            Destroy(m_blue1, 1.0f);
                            Destroy(m_blue2, 1.0f);
                            StartCoroutine(TimerInstantiationCoroutine(m_blue, m_blue2.transform.position));
                            m_firstCard = false;

                            m_foundPairs++;
                            m_gameText.text = "Number of pairs found: " + m_foundPairs.ToString();
                        }
                        else if (m_firstTag == "Blue2")
                        {
                            //
                        }
                        else
                        {
                            m_blue2.transform.Rotate(Vector3.up, 180.0f);
                            StartCoroutine(TimerRotationCoroutine(m_blue2));
                            if (m_firstTag == "Red1")
                                StartCoroutine(TimerRotationCoroutine(m_red1));
                            else if (m_firstTag == "Green1")
                                StartCoroutine(TimerRotationCoroutine(m_green1));
                            else if (m_firstTag == "Green2")
                                StartCoroutine(TimerRotationCoroutine(m_green2));
                            else if (m_firstTag == "Red2")
                                StartCoroutine(TimerRotationCoroutine(m_red2));
                            else if (m_firstTag == "Yellow1")
                                StartCoroutine(TimerRotationCoroutine(m_yellow1));
                            else if (m_firstTag == "Yellow2")
                                StartCoroutine(TimerRotationCoroutine(m_yellow2));

                            m_firstCard = false;
                        }
                    }
                }
            }
        }
    }

    private IEnumerator TimerRotationCoroutine(GameObject target)
    {
        yield return new WaitForSeconds(1.0f);
        target.transform.Rotate(Vector3.up, 180.0f);
    }

    private IEnumerator TimerInstantiationCoroutine(GameObject target, Vector3 position)
    {
        yield return new WaitForSeconds(1.0f);
        GameObject instance = Instantiate(target, position, Quaternion.identity);
        instance.GetComponent<Rigidbody>().AddForce(Vector3.up * m_strength * Time.deltaTime);
    }

    private void ChangeCardsPosition(GameObject card1, GameObject card2)
    {
        Vector3 tempPosition;

        tempPosition = card1.transform.position;
        card1.transform.position = card2.transform.position;
        card2.transform.position = tempPosition;
    }

    private void InitiateCardsPosition()
    {
        List<GameObject> cards = new List<GameObject>();
        int index0;
        int index1;

        cards.Add(m_green1);
        cards.Add(m_green2);
        cards.Add(m_red1);
        cards.Add(m_red2);
        cards.Add(m_yellow1);
        cards.Add(m_yellow2);
        cards.Add(m_blue1);
        cards.Add(m_blue2);

        for(int i = 0; i < 100; i++)
        {
            index0 = Random.Range(0, 8);
            index1 = Random.Range(0, 8);
            if(index0 == index1)
            {
                index1++;
                if (index1 == 8)
                    index1 = 0;
            }
            ChangeCardsPosition(cards[index0], cards[index1]);
        }
    }

    private void Endgame()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            SceneManager.LoadScene("MainMenuScene");
        }
    }

    //private void LookAtPlayer()
    //{
    //    m_green1.transform.LookAt(transform);
    //    m_green2.transform.LookAt(transform);
    //    m_red1.transform.LookAt(transform);
    //    m_red2.transform.LookAt(transform);
    //    m_yellow1.transform.LookAt(transform);
    //    m_yellow2.transform.LookAt(transform);
    //    m_blue1.transform.LookAt(transform);
    //    m_blue2.transform.LookAt(transform);
    //}
}

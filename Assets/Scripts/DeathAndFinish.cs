using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathAndFinish : MonoBehaviour
{
    public CharacterController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Death")
        {
            SceneManager.LoadScene("Death");
        }
        if (hit.gameObject.tag == "TheEnd")
        {
            SceneManager.LoadScene("Win");
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //if (collision.gameObject.CompareTag("Death"))
    //{
    //Debug.Log("Death");
    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}

    //if (collision.gameObject.tag == "TheEnd")
    //{
    //Debug.Log("TheEnd");
    //SceneManager.LoadScene("Level1");
    //}
    //}
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
    }
}

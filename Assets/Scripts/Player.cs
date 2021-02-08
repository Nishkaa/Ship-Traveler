using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    public Transform playerBody;
    public CharacterController controller;
    float speed = 0.3f;
 
    //m_Rigidbody = GetComponent<Rigidbody>();
    //Set the speed of the GameObject

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
            //Set Cursor to not be visible
            Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        //Player Movement
        transform.Translate(Input.GetAxis("Horizontal")* speed, 0f, -30*Time.deltaTime);
        
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
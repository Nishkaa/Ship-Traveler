using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyGameObject : MonoBehaviour
{
    public GameObject enemy;


    //Enemy Object Kills on Touch
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "enemy")
        {
            Destroy(gameObject, .5f);

            //Loading scene when player dies
            SceneManager.LoadScene("FirstLevel");
        }

    }


}


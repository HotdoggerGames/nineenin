using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public LayerMask abyss;
    public LayerMask abyss1;
    public LayerMask abyss2;
    public bool colliding;
    public bool colliding1;
    public bool colliding2;
    public Transform collider;
    public float checkRadius;
    public string CurrentScene;
    public string CurrentScene1;
    public string CurrentScene2;
    void FixedUpdate()
    {
        colliding = Physics2D.OverlapCircle(collider.position, checkRadius, abyss);
        colliding1 = Physics2D.OverlapCircle(collider.position, checkRadius, abyss1);
        colliding2 = Physics2D.OverlapCircle(collider.position, checkRadius, abyss2);
    }
    void Update()
    {

        if (colliding == true)
        {
            Debug.Log("load"); respawn();
        }
        if (colliding1 == true)
        {
            Debug.Log("load"); respawn1();
        }
        if (colliding2 == true)
        {
            Debug.Log("load"); respawn2();
        }
    }
    public void respawn() { SceneManager.LoadScene(CurrentScene, LoadSceneMode.Single); }
    public void respawn1() { SceneManager.LoadScene(CurrentScene1, LoadSceneMode.Single); }
    public void respawn2() { SceneManager.LoadScene(CurrentScene2, LoadSceneMode.Single); }

}

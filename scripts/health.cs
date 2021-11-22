using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public LayerMask abyss;
    public bool colliding;
    public Transform collider;
    public float checkRadius;
    public string CurrentScene;
    public float hp;
    public bool enm;
    public GameObject obj;
    void FixedUpdate()
    {
        colliding = Physics2D.OverlapCircle(collider.position, checkRadius, abyss);
    }
    void Update()
    {

        if (colliding == true && hp <= 0 && enm == false)
        {
             respawn();
        }
        if (colliding == true && hp <= 0 && enm == true)
        {
            obj.SetActive(false);
        }
        if (colliding == true && hp >= 0)
        {
            hp -= 1;
        }
    }
    public void respawn() { SceneManager.LoadScene(CurrentScene, LoadSceneMode.Single); }

}

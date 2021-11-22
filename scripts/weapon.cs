using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public bool e;
    public float time;
    public float maxt;
    public GameObject a;
    public GameObject b; 
    public GameObject c;
    public GameObject d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        e = Input.GetKey("e");
        if (e && time >= 0) { a.SetActive(true);b.SetActive(true); c.SetActive(true); d.SetActive(true);time--;}
        if (!e && time <= maxt) { a.SetActive(false); b.SetActive(false); c.SetActive(false); d.SetActive(false); time++; }
        if (e && time <= 0) { a.SetActive(false); b.SetActive(false); c.SetActive(false); d.SetActive(false); }
    }
}

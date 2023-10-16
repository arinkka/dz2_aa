using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    public GameObject sphere;
    public Text X;
    public GameObject button;
    void Start() { }
    void FixedUpdate()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        sphere.GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Press()
    {
        if (this.gameObject.activeSelf)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }
}

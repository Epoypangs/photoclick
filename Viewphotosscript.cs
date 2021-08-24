using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viewphotosscript : MonoBehaviour
{
    public GameObject thiss;
    public GameObject gotoo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gotomenu()
    {
        gotoo.SetActive(true);
        thiss.SetActive(false);
    }
}

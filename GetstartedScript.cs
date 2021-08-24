using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetstartedScript : MonoBehaviour
{
    public GameObject getstarted;
    public GameObject Menupage;
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
        Menupage.SetActive(true);
        getstarted.SetActive(false);
    }
}

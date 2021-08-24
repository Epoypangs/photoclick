using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpPanel : MonoBehaviour
{
    public GameObject showpanel;
  
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
        showpanel.SetActive(true);
        
    }
}

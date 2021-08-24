using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class backscript : MonoBehaviour
{
    public GameObject thiss;
   
    public GameObject hidethis;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void wake()
    {
        animator = thiss.GetComponent<Animator>();
    }
    public void playanimation()
    {
        hidethis.SetActive(false);
        thiss.SetActive(true);
     
        animator.enabled = true;
    }
}
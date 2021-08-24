using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendropdown : MonoBehaviour
{
    //public GameObject thiss;
    public GameObject thisy;
    private Animator animator;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {
        animator = thisy.GetComponent<Animator>();
    }
    public void playanimation()
    {
        counter++;
        if (counter % 2 ==1)
        {
            thisy.SetActive(true);
            animator.enabled = true;
        }
        else
        {
            thisy.SetActive(false);
            animator.enabled = false;

        }
      
    }
}

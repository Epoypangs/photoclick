using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscript : MonoBehaviour
{   public GameObject thiss;
    public GameObject thisy;
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
    private void Awake()
    {
        animator = thiss.GetComponent<Animator>();
    }
    public void playanimation()
    {
        thisy.SetActive(true);
        thiss.SetActive(true);
        animator.enabled = true;
    }
}

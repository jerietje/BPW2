using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTurns : MonoBehaviour
{
    private Animator mAnimator;
    private bool isDay = true;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator != null)
        {
            if(Input.GetKeyDown(KeyCode.E)) {
                if (isDay == true)
                {
                    mAnimator.SetTrigger("TRRED");
                    isDay = false;
                }
                else
                {
                    mAnimator.SetTrigger("TRBLUE");
                    isDay = true;
                }
            }
        }
    }
}

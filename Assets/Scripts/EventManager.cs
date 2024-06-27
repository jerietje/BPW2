using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class EventManager : MonoBehaviour
{
    [Header("Post Processing")] //To make a header in the inspector, for organization
    [SerializeField] private GameObject DayPostProcessing; //I can add my object in the inspector
    [SerializeField] private GameObject NightPostProcessing;

    [Header("Skybox")]
    [SerializeField] private Material DaySkyBox;
    [SerializeField] private Material NightSkyBox;

    [Header("Animations")]
    [SerializeField] public AnimationClip TurnRed;
    //private Animation TurnRed;

    private bool isDay = true;
    //private bool isNight = false;

    // Start is called before the first frame update
    void Start()
    {
        //TurnRed = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(isDay == true)
            {
                NightTime();
            }
            else
            {
                DayTime();
            }

        }
        
    }

    private void NightTime()
    {
        Debug.Log("CULT TIME");
        RenderSettings.skybox = NightSkyBox;
        RenderSettings.fog = true;

        DayPostProcessing.SetActive(false);
        NightPostProcessing.SetActive(true);
        //TurnRed.Play();

        isDay = false;
        //isNight = true;
    }
    private void DayTime()
    {
        Debug.Log("Normal day");
        RenderSettings.skybox = DaySkyBox;
        RenderSettings.fog = false;

        DayPostProcessing.SetActive(true);
        NightPostProcessing.SetActive(false);

        isDay = true;
        //isNight = false;
    }
}

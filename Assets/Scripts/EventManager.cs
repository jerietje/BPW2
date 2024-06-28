using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class EventManager : MonoBehaviour
{
    [Header("Post Processing")] //To make a header in the inspector, for organization
    [SerializeField] private GameObject DayPostProcessing; //I can add my object in the inspector
    [SerializeField] private GameObject NightPostProcessing;

    [Header("Skybox")]
    [SerializeField] private Material DaySkyBox;
    [SerializeField] private Material NightSkyBox;
    

    private bool isDay = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isDay == true)
            {
                NightTime();
            }
            else
            {
                DayTime();
            }

        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Menu();
        }

    }
   

    private void NightTime()
    {
        Debug.Log("CULT TIME");
        RenderSettings.skybox = NightSkyBox;
        RenderSettings.fog = true;

        DayPostProcessing.SetActive(false);
        NightPostProcessing.SetActive(true);
        

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

    private void Menu()
    {

        if (isDay == true)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

}

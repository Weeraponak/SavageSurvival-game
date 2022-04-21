using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintUI : MonoBehaviour
{
    public GameObject hintUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            hintUI.SetActive(!hintUI.activeSelf);
            /*if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                hintUI.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                hintUI.SetActive(false);
            }*/
        }
    }
}

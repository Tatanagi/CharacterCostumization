using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine.TextCore.Text;


public class GameManager : MonoBehaviour
{
    public GameObject MainMenu, Male_Interface, Female_Interface;
    

    // Male Costumization Interface
    public void Male_Costumization()
    {
        MainMenu.SetActive(false);
        Male_Interface.SetActive(true);
    }

    // Back To Main Menu
    public void Back_To_Main()
    {
        Male_Interface.SetActive(false);
        MainMenu.SetActive(true);
    }


    // Female Costumization
    public void Female_Costumization()
    {
        MainMenu.SetActive(false);
        Female_Interface.SetActive(true);
    }

    // Back To Main Menu

    public void Back_To_Main_1()
    {
        Female_Interface.SetActive(false);
        MainMenu.SetActive(true);
    }

    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCostume : MonoBehaviour

{
    // Start is called before the first frame update
    public GameObject[] Characters;
    public int selected_character = 0;
    public void NextCharacter()
    {
        Characters[selected_character].SetActive(false);
        selected_character = (selected_character + 1) % Characters.Length;
        Characters[selected_character].SetActive(true);
    }
    public void PreviusCharacter()
    {
        Characters[selected_character].SetActive(false);
        selected_character--;

        if (selected_character < 0)
        {
            selected_character += Characters.Length;
        }
        Characters[selected_character].SetActive(true);

    }
}

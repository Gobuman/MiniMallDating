using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PizzaMaking : MonoBehaviour
{
    public GameObject tomato;

    public GameObject cheese;

    public GameObject basil;

    public GameObject pineapple;

    public PizzaMaking[] PizzaMakings;

    private int points;

    public TextMeshProUGUI SpeechBubble; 


    public void Tomato()
    {
        if (!tomato.activeSelf)
        {
            tomato.SetActive(true);
            points += 1;
        }
        else
        {
            tomato.SetActive(false); 
            points -= 1;
        }

    }
    public void Cheese()
    {
        if (!cheese.activeSelf) 
        {
            cheese.SetActive(true);
            points += 1;
        }
        else
        {
            cheese.SetActive(false);
            points -= 1;
        }
    }
    public void Basil()
    {
        if (!basil.activeSelf)
        {
            basil.SetActive(true);
            points -= 1;
        }
        else
        {
            basil.SetActive(false);
            points += 1;
        }
    }
    public void Ananas()
    {
        if (!pineapple.activeSelf)
        {
            pineapple.SetActive(true);
            points -= 1;
        }
        else
        {
            pineapple.SetActive(false);
            points += 1;
        }
    }

    public void FirstPizza()
    {
        SpeechBubble.text = "make a pizza with tomato and cheese";

        if (!basil.activeSelf && !pineapple.activeSelf)
        {
            if (tomato.activeSelf && cheese.activeSelf)
            {
                SpeechBubble.text = "Mmm... delicious";
                Debug.Log("correct");
            }
        }
        
        
    }
}

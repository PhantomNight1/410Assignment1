using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public int clicks = 0;
    public TMP_Text clickText;

    public int growPlants = 25;
    public TMP_Text growPlant;
    public GameObject leaves;
    public GameObject flower;
    private void Update()
    {
        clickText.text = "Clicks: " + clicks;
    }

    public void Click()
    {
        clicks++;
    }

    public void growLeaves()
    {
        if (clicks == growPlants)
        {
            leaves.SetActive(true);
            flower.SetActive(false);
        }
        if (clicks == growPlants * 2)
        {
            flower.SetActive(true);
            leaves.SetActive(false);
        }
    }

}

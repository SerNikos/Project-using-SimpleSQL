using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
    public void GameOverMethod()
    {
        gameObject.GetComponent<TimesCliked>().DisplayClicks();
    }
    
}

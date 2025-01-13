using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public int Orbs = 0;
    public TextMeshProUGUI OrbText;
    public void Awake()
    {
        if(GameManager.gameManager !=null && GameManager.gameManager != this)
        Destroy(gameObject);
        else
        {
            GameManager.gameManager= this;
            DontDestroyOnLoad(gameObject);
        }
    }
 
    public void OrbCollected()
    {
        Orbs++;
        OrbText.text= ": "+Orbs;
    }
}

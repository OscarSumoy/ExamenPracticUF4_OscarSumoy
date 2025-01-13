using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : MonoBehaviour, ICollectable
{
   public void OnCollected()
   {
    Debug.Log("Orbe");
    GameManager.gameManager.OrbCollected();
    Destroy(gameObject);
   }
}

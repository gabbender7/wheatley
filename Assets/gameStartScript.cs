using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
   public void StartButton(){
	   SceneManager.LoadScene("GameplayScene");
   }

   public void CreditsButton(){
	   SceneManager.LoadScene("CreditScene");
   }
}
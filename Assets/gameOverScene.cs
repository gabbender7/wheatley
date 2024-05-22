using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
   public void RestartButton(){
	   SceneManager.LoadScene("GameplayScene");
   }

   public void MainMenuButton(){
	   SceneManager.LoadScene("GameStartScene");
   }
}
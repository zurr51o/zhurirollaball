using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 
public class GameManager : MonoBehaviour
{
   //create script
   public static GameManager Instance { get; private set;}
   public int score = 0; //PLAYER SCORE
   public TextMeshProUGUI scoreText; //Holds score text
   public GameObject victoryText; //A Var to hold our victory text object
   public GameObject pickupParent; // a var to hold the pickup parent game object; this is used to count our pickups
   public int totalPickups =0; //a var to store the total of pickups in the scene
   public GameObject Player;
   public List <GameObject> enemies;
   
   
   
   // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null) //If there is no other copy of the script
        {
            Instance = this; //This = "This Instance / self"
        }
        else
        {
            //Delete the extra copy
            Debug.LogWarning("There can only be one instance of [GameManager]");
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    private void Start()
    {
        score = 0;
        UpdateScoreText();
        
        victoryText.SetActive(false);
        totalPickups = pickupParent.transform.childCount; //Count how many pickups are in the level
        
    }
    
    public void UpdateScore(int amount)
    {
        score += amount;
        UpdateScoreText();
        if (totalPickups <= 0) //IF there are no pickups in the level...
        {
            WinGame(); //Win the gME    
        }
    }
    
    
    
    
    public void UpdateScoreText()
    {
        totalPickups = pickupParent.transform.childCount -1; //Count how many pickups are in the level
        scoreText.text = "Score" + score.ToString(); //Updateds the score text from the players scene
    }
    
    
    public void WinGame()
    {
        victoryText.SetActive(true); //Enable out victory text
    }
    public void GameOver()
    {
        Invoke("LoadCurrentLevel", 2f);
    }
    
    public void LoadCurrentLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex));
    }
    
    public void DisableEnemies()
    {
    foreach(GameObject enemy in enemies) //loop that iterates through enemies
    {
        if (enemy != null) //checks each index for an active enemy
        {
            enemy.SetActive(false); //disables enemy AT index
        }
    }
    }
    void Update();
     if (Player == null)
    {
        GameOver();
    }
}

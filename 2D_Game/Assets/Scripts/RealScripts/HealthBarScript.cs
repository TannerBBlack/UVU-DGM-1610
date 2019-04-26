using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBarScript : MainMenu
{
    Image healthBar;
    float maxHealth = 100f;
    public static float health;
    public LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;

        if(health <= 0)
        {
            SceneManager.LoadScene(levelToLoad);
            health = maxHealth;
        }
    }
}

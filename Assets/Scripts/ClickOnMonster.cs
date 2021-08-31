using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnMonster : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void OnMouseDown ()
    {
        gameManager.AddScore();
        Destroy(gameObject);
    }
}

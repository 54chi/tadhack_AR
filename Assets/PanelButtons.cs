using UnityEngine;
using System.Collections;

public class PanelButtons : MonoBehaviour {

    //refrence for the pause menu panel in the hierarchy
    public GameObject menuPanel;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
    }

    //function to pause the game
    public void OpenRecipes()
    {
        menuPanel.SetActive(true);
    }
    //function to unpause the game
    public void CloseRecipes()
    {
        menuPanel.SetActive(false);
    }
}

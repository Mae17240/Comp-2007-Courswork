using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject panel;

    
    void Start()
    {
        
        panel.SetActive(false); //set pannel to false
    }
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.I)) //check if the user has pressed the key I to bring up the menu.
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}

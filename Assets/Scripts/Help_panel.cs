using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject panel;

    
    void Start()
    {
        
        panel.SetActive(false);
    }
    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.I))
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}

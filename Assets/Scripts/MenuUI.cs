using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    // public TextMeshProUGUI nameEntered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NameEntered(string name)
    {
        NameManager.Instance.playerName = name;
    }
    
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}

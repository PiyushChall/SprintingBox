using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuScript : MonoBehaviour
{
    public int pla;
    public int lvl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playy()
    {
        SceneManager.LoadScene(pla);
    }
    public void levelSelect()
    {
        SceneManager.LoadScene(lvl);
    }
    public void quitt()
    {
        Application.Quit();
    }
}

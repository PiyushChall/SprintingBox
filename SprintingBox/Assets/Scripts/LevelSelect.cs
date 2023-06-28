using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public int one;
    public int two;
    public int three;
    public int four;
    public int five;
    public int six;
    public int seven;
    public int eight;
    public int nine;
    public int ten;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lvl1()
    {
        SceneManager.LoadScene(one);
    }
    public void lvl2()
    {
        SceneManager.LoadScene(two);
    }
    public void lvl3()
    {
        SceneManager.LoadScene(three);
    }
    public void lvl4()
    {
        SceneManager.LoadScene(four);
    }
    public void lvl5()
    {
        SceneManager.LoadScene(five);
    }
    public void lvl6()
    {
        SceneManager.LoadScene(six);
    }
    public void lvl7()
    {
        SceneManager.LoadScene(seven);
    }
    public void lvl8()
    {
        SceneManager.LoadScene(eight);
    }
    public void lvl9()
    {
        SceneManager.LoadScene(nine);
    }
    public void lvl10()
    {
        SceneManager.LoadScene(ten);
    }
}

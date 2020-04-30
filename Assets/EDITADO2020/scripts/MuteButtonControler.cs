using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButtonControler : MonoBehaviour
{
    public GameObject upSprite;
    public GameObject downSprite;
    public float downTime = 0.1f;
    private enum buttonStates
    {
        up = 0,
        down
    }
    private buttonStates currentState = buttonStates.up;
    private float nextStateTime = 0.0f;
    void Start()
    {
        upSprite.SetActive(true);
        downSprite.SetActive(false);
    }
    void OnMouseDown()
    {
        if (AudioListener.volume == 0)
        {

            upSprite.SetActive(true);
            downSprite.SetActive(false);
            AudioListener.volume = 1;
        }
        else
        {

            upSprite.SetActive(false);
            downSprite.SetActive(true);
            AudioListener.volume = 0;
        }
    }
    void Update()
    {
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalNode : MonoBehaviour
{
    SpriteRenderer sr;
    public Sprite none;
    public Sprite left;
    public Sprite right;
    public string current;

    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = left;
        SwitchSprite();
    }

    
    void Update()
    {

    }

    void SwitchSprite()
    {
        if (current == "left")
        {
            Debug.Log("Choose Left");
            sr.sprite = left;
        }
        else if (current == "right")
        {
            Debug.Log("Choose Right");
            sr.sprite = right;
        }
        else
        {
            Debug.Log("Choose None");
            sr.sprite = none;
        }
    }
}

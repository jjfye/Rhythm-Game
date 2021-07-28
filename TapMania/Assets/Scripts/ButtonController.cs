using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer sprite_Renderer;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {
        sprite_Renderer = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            sprite_Renderer.sprite = pressedImage;
        }
        if(Input.GetKeyUp(keyToPress))
        {
            sprite_Renderer.sprite = defaultImage;
        }
    }
}

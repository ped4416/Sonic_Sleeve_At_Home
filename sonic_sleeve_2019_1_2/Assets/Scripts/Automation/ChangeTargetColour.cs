using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTargetColour : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Color col = new Color();

    // Start is called before the first frame update
    void Start()
    {
        col = Color.green;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("HIT");
        sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.color = col;
    }

    private void OnCollisionExit(Collision collision)
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();
        sprite.color = Color.white;
    }
}
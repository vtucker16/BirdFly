using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbMove : MonoBehaviour
{
   public float speed = 9.0f;
   public Sprite LeftDown;
   public Sprite LeftUp;
   public Sprite RightDown;
   public Sprite RightUp;
    // Start is called before the first frame update
   public AudioClip clip;
   public float volume = 1; 
    
    void Start()
    {
        
    }


    void MoveObject(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate((Vector2.left * Time.deltaTime) * speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate((Vector2.up * Time.deltaTime) * speed);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate((Vector2.down * Time.deltaTime) * speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
        if(Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<SpriteRenderer>().sprite = LeftUp;
            if(Input.GetKey(KeyCode.DownArrow)){
             GetComponent<SpriteRenderer>().sprite = LeftDown;
            }
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            GetComponent<SpriteRenderer>().sprite = RightUp;
            if(Input.GetKey(KeyCode.DownArrow)){
             GetComponent<SpriteRenderer>().sprite = RightDown;
            }
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            if(Input.GetKey(KeyCode.RightArrow)){
             GetComponent<SpriteRenderer>().sprite = RightDown;
            } 
            if (Input.GetKey(KeyCode.LeftArrow)){
                GetComponent<SpriteRenderer>().sprite = LeftDown;
            }
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            AudioSource.PlayClipAtPoint(clip, transform.position, volume);
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Exit : MonoBehaviour
{
    public bool isTouch;
    public bool isClear;
    private void Start()
    {
        isClear = false;
        isTouch = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isClear==false) {
            isTouch = true;
            isClear = true;
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            isTouch = false;
            isClear = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player") {

        Destroy(GameObject.Find("Cube"));
            Debug.Log("Destroyed");
        }
    }
  public  bool GetIsTouch()
    {
        
        return isTouch;
    }
    public bool GetisClear()
    {
        return isClear;
    }
}

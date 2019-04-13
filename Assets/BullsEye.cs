using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullsEye : MonoBehaviour
{
    public string alignTo = "left";
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        var Target = GameObject.Find("BullsEye");

        Target.transform.position = new Vector3(pos.x, pos.y,-9);
        if (alignTo == "Left") transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Vector3.zero).x, transform.position.y, transform.position.z);
        else if (alignTo == "Right")
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Vector3.right * Screen.width).x, transform.position.y, transform.position.z);

        }
    }
}

    

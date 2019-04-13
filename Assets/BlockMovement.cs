using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 
    BlockMovement : MonoBehaviour
{
    public GameObject Targets { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        //Creat random variable
        float xPos = Random.Range(-7, 3);
        float yVel = Random.Range(10, 14);
        float xVel = Random.Range(-4, 3);

        //Move object somewhere on the x-axis
        if (this.transform.position.y < -6)
        {
            if (xPos < -3)
                xVel = Random.Range(-1, 7);
            if (xPos > 3)
                xVel = Random.Range(-3, 3);

            xPos = Random.Range(-7, 8);
            this.transform.position = new Vector2(xPos, -6);

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
        }
       
    }
    private void OnMouseOver()
    {
        if(Input.GetMouseButton(0))
        {
            Destroy(gameObject);
        }
    }

}

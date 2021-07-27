using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
            transform.Translate(-3, 0, 0);
		}
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
		{
            transform.Translate(3, 0, 0);
		}
    }

    public void LButtonDown()
	{
        transform.Translate(-2, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(2, 0, 0);
    }
}

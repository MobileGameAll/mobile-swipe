using UnityEngine;
using System.Collections;

public class ExampleSwipe : MonoBehaviour
{

    private Vector2 startPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                case TouchPhase.Ended:
                    Vector2 endPos = touch.position;
                    float angle = Vector2.Angle(startPos, endPos);
                    transform.eulerAngles = new Vector3(0, 0, angle);
                    break;
            }


        }
    }
}

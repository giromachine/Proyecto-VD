using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    private bool isAlreadyopen = false;
    public SpriteRenderer sp;

    public float deadZoneMaxDistance = 0;

    public GameObject app;

    private Vector2 mousePosition;
    private Vector2 startMousePosition;
    private Vector2 startDistance;

    private bool isPresed = false;
    private bool isCreated = false;
    private bool isHold = false;

    private Vector2 distanceTraveled;
    private Vector2 unholdBottomPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!app.activeInHierarchy) {
            isCreated = false;
            //Debug.Log("destruida");
        }
            

        unholdBottomPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        distanceTraveled = unholdBottomPosition - startDistance;
        

        if (isPresed == true && distanceTraveled.magnitude > deadZoneMaxDistance)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log(distanceTraveled.magnitude);
            this.gameObject.transform.position = new Vector2(mousePosition.x - startMousePosition.x, mousePosition.y - startMousePosition.y);
            isHold = true;
        }
    }

    private void OnMouseDown()
    {
        HoldToMove();
        
    }

    private void OnMouseUp()
    {
        isPresed = false;
    }

    private void OnMouseUpAsButton()
    {
        if (!isCreated && !isHold)
        {
            app.SetActive(true);
            isCreated = true;
            if (!isAlreadyopen)
            {
                sp.enabled = false;
                isAlreadyopen = true;
            }
        }
        isHold = false;
    }

    void HoldToMove() {

        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            startMousePosition.x = mousePosition.x - this.transform.localPosition.x;
            startMousePosition.y = mousePosition.y - this.transform.localPosition.y;

            startDistance = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;

            isPresed = true;        
        }
    }
}


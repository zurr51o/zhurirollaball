using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    //create script station
    public int pointValue = 1; // Value to increase points by
    public float rotateSpeed = 5f; // controls speed of rotation
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) // If the other collider hits this gane object, check tag to see if it is "Player"
        {
            GameManager.Instance.UpdateScore(pointValue);
            Destroy(this.gameObject); //Destroy pickup
        }
    
    
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15,30,45)*rotateSpeed * Time.deltaTime); 
    }
}

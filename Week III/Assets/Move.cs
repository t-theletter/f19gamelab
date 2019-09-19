//using EO.Internal;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    float horz;
    float vert;

    public Rigidbody2D rb;
    public float forceAmount;


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        //Debug.Log(horz + "" + vert);
        //GetKey == constant action
        //is active while pressed down
        //GetKeyDown == percision, accuracy
        //GetKeyUp == stop

        transform.Translate(horz * Time.deltaTime, vert * Time.deltaTime, 0);

        rb.AddForce(new Vector2(horz, vert));

        }
    }
 

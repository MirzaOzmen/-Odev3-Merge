using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int Speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
         Vector2 Movement = new Vector2(yatay, dikey);

        transform.Translate(Movement * Speed * Time.deltaTime);
            }
}

 using UnityEngine;
 using System.Collections;
 
 public class MoveToPosition : MonoBehaviour {
 
    public float speed = 1.0f;
    private Vector3 target;
 
    private Animator anim;

    void Start () {
        target = transform.position;
        anim = GetComponent<Animator>();
    }
     
    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
        if(transform.position == target){
            anim.SetBool("isWalking", false);
        }else{
            anim.SetBool("isWalking", true);
        }
    }    
 }

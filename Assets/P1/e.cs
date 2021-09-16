using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class e : MonoBehaviour
{
    public float rotationSpeed = 1;
  //  public float rotationLength = 10;
  //  public Vector3 startAngle;
  //  public Vector3 endAngle;
    public float eAngle;
    public float sAngle;
   // Vector3 curve1 = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 angle = this.transform.eulerAngles;
        angle.z = sAngle;
        this.transform.eulerAngles = angle;
        //this.transform.eulerAngles = startAngle;
    }

    // Update is called once per frame      
    void Update()
    {
        Vector3 tempAngle = this.transform.eulerAngles;
        //  teamAngle.z = tempAngle.z + rotationSpeed;
        tempAngle.z = tempAngle.z + rotationSpeed + Time.deltaTime;

        this.transform.eulerAngles = tempAngle;
      //  this.transform.eulerAngles = Vector3.SmoothDamp(this.transform.eulerAngles, endAngle, ref curve1, rotationSpeed);
    }
}

using UnityEngine;

public class UnityPlanet : MonoBehaviour {
 
    // orbits around a "star" at the origin with fixed mass
    public float starMass = 1000f;
 
    // Use this for initialization
    void Start () {
        float initV = Mathf.Sqrt(starMass / transform.position.magnitude);
        GetComponent<Rigidbody>().velocity = new Vector3(0, initV, 0);
    }
 
    // Update is called once per frame
    void FixedUpdate () {
        float r = Vector3.Magnitude(transform.position);
        float totalForce = -(starMass) / (r * r);
        Vector3 force = (transform.position).normalized * totalForce;
        GetComponent<Rigidbody>().AddForce(force);
    }
}
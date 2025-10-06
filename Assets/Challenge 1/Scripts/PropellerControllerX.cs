using UnityEngine;

public class PropellerControllerX : MonoBehaviour
{
    public float roateSpd;
    Vector3 zAxis = new Vector3(0, 0, 1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * roateSpd * Time.deltaTime);
    }
}

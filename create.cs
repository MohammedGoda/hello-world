using UnityEngine;
using System.Collections;

public class create : MonoBehaviour {

    public GameObject lastObj;
    
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //dfdfdfdsfffsdajdaskdasjkdhasdkadhaskdkjahkdjhakjdkasdjashdjah
        Debug.Log(lastObj.gameObject.name);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lastObj = (GameObject)Instantiate(lastObj, EditedTransform(lastObj), Quaternion.Euler(0, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //lastObj = (GameObject)Instantiate(lastObj, EditedTransform(lastObj), lastObj.transform.rotation * Quaternion.Euler(0, 90, 0));
            lastObj = (GameObject)Instantiate(lastObj, EditedTransform(lastObj), Quaternion.Euler(0, 90, 0));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //lastObj = (GameObject)Instantiate(lastObj, EditedTransform(lastObj), lastObj.transform.rotation * Quaternion.Euler(0, -90, 0));
            lastObj = (GameObject)Instantiate(lastObj, EditedTransform(lastObj), Quaternion.Euler(0, -90, 0));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            lastObj = (GameObject)Instantiate(lastObj, EditedTransform(lastObj), Quaternion.Euler(0, 180, 0));
        }

        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            lastObj = (GameObject) Instantiate(lastObj, lastObj.transform.position + new Vector3(0, 0, 2), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            lastObj = (GameObject)Instantiate(lastObj, lastObj.transform.position + new Vector3(0.5f, 0, 1.5f), Quaternion.identity * Quaternion.Euler(0, 90, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lastObj = (GameObject)Instantiate(lastObj, lastObj.transform.position + new Vector3(-0.5f, 0, 1.5f), Quaternion.identity * Quaternion.Euler(0, -90, 0));
        }
        */

    }

    Vector3 EditedTransform(GameObject obj)
    {
        Vector3 editedPos = obj.transform.position + (1f * obj.transform.forward);
        return editedPos;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnStar : MonoBehaviour
{
    [SerializeField]
    int addScore=0;
    [SerializeField]
    GameObject FireWork;
    private void OnMouseDown()
    {
        UIScore.Instance.AddScore(addScore);
        GameObject FireWorkObj = Instantiate(FireWork) as GameObject;
        FireWorkObj.transform.position=new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //not recomented but oke
        Destroy(gameObject);

    }

    private void Update()
    {
        if(transform.position.y<-20)
        {
            Destroy(gameObject);
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Linq;

public class Rotator : MonoBehaviour
{
    public string palindrom;
    //when you see this text me!!
    private void Start()
    {
        BoxSpawner.S_no++;

        float RandNo = Random.Range(0f, 10f);
        palindrom = (int)RandNo + "a" + 2;

        var inversed = new string(palindrom.ToCharArray().Reverse().ToArray());
        palindrom = palindrom + inversed;
        inversed = new string(palindrom.ToCharArray().Reverse().ToArray());
        if (BoxSpawner.S_no > 12)
            palindrom = palindrom + inversed + BoxSpawner.S_no;
        else
            palindrom = palindrom + inversed;

        transform.GetChild(0).GetComponent<TextMesh>().text = palindrom;

        //print(palindrom);
    }
    void Update()
    {
        transform.Rotate(new Vector3(0,30 * Time.deltaTime, 0) );
    }
}
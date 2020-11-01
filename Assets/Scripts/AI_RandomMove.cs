using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_RandomMove : MonoBehaviour
{
    public Transform player;
    public GameObject bananaPrefab;      
    private List<GameObject> bananas;
    // Start is called before the first frame update
    void Start()
    {
        bananas = new List<GameObject>();
    }
    private void CreateNewBanana()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject newPink = Instantiate(bananaPrefab, player.position + new Vector3(0, 0, 10), Quaternion.identity) as GameObject;
            bananas.Add(newPink);
        }
    }
    // Update is called once per frame
    void Update()
    {
        CreateNewBanana();
    }
}

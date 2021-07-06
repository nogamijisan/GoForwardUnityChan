using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

    public GameObject cubePrefab;

    // time count
    private float delta = 0;

    // generate span
    private float span = 1.0f;

    // generate position x
    private float genPosX = 12;

    // generate offset y
    private float offsetY = 0.3f;

    // generate Y span
    private float spaceY = 6.9f;

    // generate offset x
    private float offsetX = 0.5f;

    // generate X span
    private float spaceX = 0.4f;

    // generate limit count
    private int maxBlockNum = 4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            int n = Random.Range(1, maxBlockNum + 1);

            for(int i=0;i<n; i++)
            {
                GameObject go = Instantiate(cubePrefab);
                go.transform.position
                    = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
            }

            this.span = this.offsetX + this.spaceX * n;

        }
    }


}

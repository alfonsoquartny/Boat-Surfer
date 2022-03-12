using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvulationScript : MonoBehaviour
{
    public int activeLevel;
    public int maxLevel;
    public bool isTemas;

    public Mesh Level1Mesh;
    public Mesh Level2Mesh;
    public Mesh Level3Mesh;
    public Mesh Level4Mesh;
    public Mesh Level5Mesh;
    public Mesh Level6Mesh;
    public Mesh Level7Mesh;
    public Mesh Level8Mesh;

    public MeshFilter meshFilter;

    public MeshRenderer mesh;

    void Start()
    {
        activeLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeLevel == 1)
        {
            
            meshFilter.mesh = Level1Mesh;
        }
        if (activeLevel == 2)
        {
            meshFilter.mesh = Level2Mesh;
        }

        if (activeLevel == 3)
        {
            meshFilter.mesh = Level3Mesh;
        }
        if (activeLevel == 4)
        {
            meshFilter.mesh = Level4Mesh;
        }
        if (activeLevel == 5)
        {
            meshFilter.mesh = Level5Mesh;
        }
        if (activeLevel == 6)
        {
            meshFilter.mesh = Level6Mesh;
        }
        if (activeLevel == 7)
        {
            meshFilter.mesh = Level7Mesh;
        }
      
        if (activeLevel == 8)
        {
            meshFilter.mesh = Level8Mesh;
        }



        if (isTemas == true && activeLevel < maxLevel)
        {
            activeLevel = activeLevel + 1;
            isTemas = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LevelUp"))
        {
            isTemas = true; 
        }
    }
}

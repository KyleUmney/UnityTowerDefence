using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBuilder : MonoBehaviour
{
  public List<GameObject> grid;
  public GameObject tile;
  public GameObject t;
  public int gridXSize;
  public int gridZSize;

  // Use this for initialization
  void Start()
  {
    CreateGrid();
  }

  // Update is called once per frame
  void Update()
  {

  }

  protected void CreateGrid()
  {
    var tileXPosition = new Vector3(0, 0, 0);
    var tileZPosition = new Vector3(0, 0, 0);

    for (int y = 0; y < gridZSize; y++)
    {
      for (int i = 0; i < gridXSize; i++)
      {
        tileXPosition.x += 1;
        grid.Add(tile);

        Instantiate(grid[i], new Vector3(tileXPosition.x, 0, tileZPosition.z), Quaternion.identity, t.gameObject.transform);
      }
      tileZPosition.z += 1;
      tileXPosition.x = 0;
    }
  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class Level1Manager : LevelBase
{
    // First, create a reference to the prefab you want to instantiate
    public GameObject prefab;
    public override void Setup(LevelHandler handler)
    {
        base.Setup(handler);
        print("china");
        handler.spawn(prefab,new Vector3 (0,0,0));
        handler.spawn(prefab, new Vector3(5, 0, 0));
        handler.spawn(prefab, new Vector3(10, 5, 0));

    }
}

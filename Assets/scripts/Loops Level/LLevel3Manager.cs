using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLevel3Manager : LevelBase
{
    public GameObject prefab; // Reference to the coin prefab
    public List<Coin> coins; // List to store the coins
    float platformLevel = 0.5f;
    public override void Setup(LevelHandler handler)
    {
        base.Setup(handler);
        print("Level1Manager Running");
        handler.spawn(prefab, new Vector3(0, platformLevel, 0));
        handler.spawn(prefab, new Vector3(0, platformLevel, 6));
        handler.spawn(prefab, new Vector3(0, platformLevel, 12));
        handler.spawn(prefab, new Vector3(6, platformLevel, 12));
        handler.spawn(prefab, new Vector3(12, platformLevel, 12));
        handler.spawn(prefab, new Vector3(12, platformLevel, 6));
        handler.spawn(prefab, new Vector3(12, platformLevel, 0));
        handler.spawn(prefab, new Vector3(6, platformLevel, 0));

        handler.spawn(prefab, new Vector3(0, platformLevel, -6));
        handler.spawn(prefab, new Vector3(0, platformLevel, -12));
        handler.spawn(prefab, new Vector3(-6, platformLevel, -12));
        handler.spawn(prefab, new Vector3(-12, platformLevel, -12));
        handler.spawn(prefab, new Vector3(-12, platformLevel, -6));
        handler.spawn(prefab, new Vector3(-12, platformLevel, 0));
        handler.spawn(prefab, new Vector3(-6, platformLevel, 0));


        handler.spawn(prefab, new Vector3(12, platformLevel, -6));
        handler.spawn(prefab, new Vector3(12, platformLevel, -12));
        handler.spawn(prefab, new Vector3(6, platformLevel, -12));

        handler.spawn(prefab, new Vector3(-12, platformLevel, 6));
        handler.spawn(prefab, new Vector3(-12, platformLevel, 12));
        handler.spawn(prefab, new Vector3(-6, platformLevel, 12));

        // Instantiate the coins and add them to the list
        coins = new List<Coin>();
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Coin"))
        {
            coins.Add(obj.GetComponent<Coin>());
        }
    }

    /*
for i = 1, 4 do
    for i = 1, 4 do
        MoveForward(12)
        Turn("right")
    end
    Turn("left") 
end

    */
}
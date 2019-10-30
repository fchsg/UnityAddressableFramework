using Core;
using UnityEngine;

public class SimpleScene : MonoBehaviour
{
    private const string RootPath =   "Assets/AddressableSimpleData/";

    private async void Start()
    {
        var prefab2 = await AddressableLoader.LoadAssetAsync<Object>($"{RootPath}Prefabs/Single/PrefabSprite.prefab");
        Instantiate(prefab2);
        
        var prefab = await AddressableLoader.LoadAssetAsync<Object>($"{RootPath}Prefabs/Single/PrefabCube.prefab");
        Instantiate(prefab);
        
    }

    private void Update()
    {
        
    }
}

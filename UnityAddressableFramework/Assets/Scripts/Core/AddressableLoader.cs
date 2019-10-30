using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Object = UnityEngine.Object;

namespace Core
{
    public static class AddressableLoader
    {
        public static async Task<T> LoadAssetAsync<T>(string name) where T : Object
        {
            T result = null;
            
            var handle = Addressables.LoadAssetAsync<T>(name);
            await handle.Task;

            if (handle.IsDone && handle.Status == AsyncOperationStatus.Succeeded)
            {
                result = handle.Result;
            }
            else
            {
                Debug.LogError($" {name} Load Failed");
            }
            
            return result;
        }

        public static async Task<AsyncOperationHandle<T>> LoadAssetHandleAsync<T>(string name)
        {
            var handle = Addressables.LoadAssetAsync<T>(name);
            await handle.Task;

            if (handle.Status != AsyncOperationStatus.Succeeded)
            {
                Debug.LogError($" {name} Load Failed");
            }

            return handle;
        }

        

    }
}

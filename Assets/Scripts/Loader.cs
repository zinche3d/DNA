using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    private AsyncOperationHandle<SceneInstance> _currentSceneHandle;
    [SerializeField] private string _sceneKey;

    private void Awake(){
        LoadScene(_sceneKey);
    }

    public void LoadScene(string sceneKey)
    {
        _currentSceneHandle = Addressables.LoadSceneAsync( sceneKey, LoadSceneMode.Additive,true);
        _currentSceneHandle.Completed += OnSceneLoaded;
    }

    private void OnSceneLoaded(AsyncOperationHandle<SceneInstance> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Сцена {handle.Result.Scene.name} успешно загружена!");
        }
        else
        {
            Debug.LogError($"Не удалось загрузить сцену {handle.DebugName}");
        }
    }
    
    public void UnloadScene()
    {
        if (_currentSceneHandle.IsValid())
        {
            Addressables.UnloadSceneAsync(_currentSceneHandle);
            Debug.Log("Сцена выгружена.");
        }
    }
}
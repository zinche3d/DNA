using UnityEditor;
using UnityEngine;
public static class SelectSameScripts
{
    [MenuItem("CONTEXT/Component/Select Same Scripts")]
    private static void SelectAll(MenuCommand command)
    {
        var component = command.context as Component;
        if (component == null) return;

        var type = component.GetType();
        //var all = Object.FindObjectsOfType(type);
        var all = Object.FindObjectsByType(type, FindObjectsSortMode.None);

        GameObject[] objs = new GameObject[all.Length];
        for (int i = 0; i < all.Length; i++)
            objs[i] = ((Component)all[i]).gameObject;

        Selection.objects = objs;
        Debug.Log($"Selected {objs.Length} objects with [{type.Name}]");
    }
}

using UnityEngine;
using UnityEditor;
using System.Collections;
 
public class StepCreater : EditorWindow {
    private GameObject parent;
    private GameObject prefab;
    private int numX = 1;
    private int numY = 1;
    private int numZ = 1;
    private float intervalX = 1;
    private float intervalY = 1;
    private float intervalZ = 1;
 
    [MenuItem("GameObject/Create Other/Create Steps")]
    static void Init() {
        EditorWindow.GetWindow<StepCreater>(true, "Create Buoys");
    }
 
    void OnEnable() {
        if (Selection.gameObjects.Length > 0) parent = Selection.gameObjects[0];
    }
 
    void OnSelectionChange() {
        if (Selection.gameObjects.Length > 0) prefab = Selection.gameObjects[0];
        Repaint();
    }
 
    void OnGUI() {
        try {
            parent = EditorGUILayout.ObjectField("Parent", parent, typeof(GameObject), true) as GameObject;
            prefab = EditorGUILayout.ObjectField("Prefab", prefab, typeof(GameObject), true) as GameObject;
 
            GUILayout.Label("X : ", EditorStyles.boldLabel);
            numX = int.Parse(EditorGUILayout.TextField("num", numX.ToString()));
            intervalX = int.Parse(EditorGUILayout.TextField("interval", intervalX.ToString()));
 
            GUILayout.Label("Y : ", EditorStyles.boldLabel);
            numY = int.Parse(EditorGUILayout.TextField("num", numY.ToString()));
            intervalY = int.Parse(EditorGUILayout.TextField("interval", intervalY.ToString()));
 
            GUILayout.Label("Z : ", EditorStyles.boldLabel);
            numZ = int.Parse(EditorGUILayout.TextField("num", numZ.ToString()));
            intervalZ = int.Parse(EditorGUILayout.TextField("interval", intervalZ.ToString()));
 
            GUILayout.Label("", EditorStyles.boldLabel);
            if (GUILayout.Button("Create")) Create();
        } catch (System.FormatException) {}
    }
 
    private void Create() {
        if (prefab == null) return;
 
        int count = 0;
        Vector3 pos;
 
        pos.x = -(numX - 1) * intervalX / 2;
        for (int x = 0; x < numX; x++) {
            pos.y = -(numY - 1) * intervalY / 2;
            for (int y = 0; y < numY; y++) {
                pos.z = -(numZ - 1) * intervalZ / 2;
                for (int z = 0; z < numZ; z++) {
                    GameObject obj = Instantiate(prefab, pos, Quaternion.identity) as GameObject;
                    obj.name = prefab.name + count++;
                    if (parent) obj.transform.parent = parent.transform;
                    Undo.RegisterCreatedObjectUndo(obj, "Create Buoys");
 
                    pos.z += intervalZ;
                }
                pos.y += intervalY;
            }
            pos.x += intervalX;
        }
    }
}
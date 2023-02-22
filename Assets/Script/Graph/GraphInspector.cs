//using Unity.VisualScripting.FullSerializer;
//using UnityEditor;

//using UnityEngine;


////basically modify the GUI for generate Graph button
//[CustomEditor(typeof(GridGraph))]
//public class GraphInspector : Editor {
//    private int generationGridColumns;
//    private int generationGridRows;
//    private float generationGridCellSize;

//    //modify InspectorGUI by adding buttons
//    public override void OnInspectorGUI() {
//        DrawSerializedProperties();

//        GridGraph graph = (GridGraph)target;

//        if (graph.Count > 0) {
//            if (GUILayout.Button("Clear Graph"))
//                graph.Clear();
//        }

//        DrawGenerationControls();
//    }

//    private void DrawSerializedProperties() {
//        SerializedProperty begin = serializedObject.GetIterator();
//        if (begin != null) {
//            SerializedProperty it = begin.Copy();
//            if (it.NextVisible(true)) {
//                do { EditorGUILayout.PropertyField(it); }
//                while (it.NextVisible(false));
//            }
//        }

//        serializedObject.ApplyModifiedProperties();
//    }

//    protected void DrawHorizontalLine(int height = 1) {
//        Rect rect = EditorGUILayout.GetControlRect(false, height);
//        rect.height = height;
//        EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
//    }

//    private void DrawGenerationControls() {
//        GridGraph graph = (GridGraph)target;

//        EditorGUI.BeginChangeCheck();
//        {
//            if (graph.Count == 0) {
//                EditorGUILayout.Space(10);

//                EditorGUILayout.BeginVertical(EditorStyles.helpBox);
//                {
//                    GUILayout.Label("Graph Options", EditorStyles.boldLabel);
//                    EditorGUILayout.Space(5);

//                    generationGridColumns = EditorGUILayout.IntField("Number of Columns", graph.genGridCols);
//                    generationGridColumns = generationGridColumns < 0 ? 0 : generationGridColumns;
//                    generationGridRows = EditorGUILayout.IntField("Number of Rows", graph.genGridRows);
//                    generationGridRows = generationGridRows < 0 ? 0 : generationGridRows;
//                    generationGridCellSize = EditorGUILayout.FloatField("Grid Cell Size", graph.genGridCellSize);
//                    generationGridCellSize = generationGridCellSize < 0 ? 0 : generationGridCellSize;

//                    EditorGUILayout.Space(15);
//                    if (GUILayout.Button("Generate Graph")) {
//                        graph.GenerateGrid();
//                        EditorUtility.SetDirty(graph);
//                    }
//                }
//                EditorGUILayout.EndVertical();
//            }
//        }
//        if (EditorGUI.EndChangeCheck()) {
//            Undo.RecordObject(target, "Graph 'Generation Options' inspector changes");
//            graph.genGridCols = generationGridColumns;
//            graph.genGridRows = generationGridRows;
//            graph.genGridCellSize = generationGridCellSize;
//        }
//    }
//}

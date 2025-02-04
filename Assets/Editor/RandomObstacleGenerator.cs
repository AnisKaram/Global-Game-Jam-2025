using UnityEngine;
using UnityEditor;

public class RandomObstacleGenerator : EditorWindow
{
    // List of obstacle prefabs
    [SerializeField] private GameObject[] obstaclePrefabs;

    // Range for random positions
    [SerializeField] private Vector2 minPosition = new Vector2(-10f, -5f);
    [SerializeField] private Vector2 maxPosition = new Vector2(10f, 5f);

    // Number of obstacles to generate
    [SerializeField] private int obstacleCount = 10;

    private SerializedObject serializedObject;
    private SerializedProperty prefabsProperty;

    [MenuItem("Tools/Random Obstacle Generator")]
    public static void ShowWindow()
    {
        GetWindow<RandomObstacleGenerator>("Random Obstacle Generator");
    }

    private void OnEnable()
    {
        // Initialize SerializedObject and properties
        serializedObject = new SerializedObject(this);
        prefabsProperty = serializedObject.FindProperty("obstaclePrefabs");
    }

    private void OnGUI()
    {
        GUILayout.Label("Random Obstacle Generator", EditorStyles.boldLabel);

        // Display serialized fields
        serializedObject.Update();

        EditorGUILayout.PropertyField(prefabsProperty, new GUIContent("Obstacle Prefabs"), true);

        minPosition = EditorGUILayout.Vector2Field("Min Position", minPosition);
        maxPosition = EditorGUILayout.Vector2Field("Max Position", maxPosition);

        obstacleCount = EditorGUILayout.IntField("Obstacle Count", obstacleCount);

        serializedObject.ApplyModifiedProperties();

        GUILayout.Space(10);

        // Generate obstacles button
        if (GUILayout.Button("Generate Obstacles"))
        {
            GenerateObstacles();
        }
    }

    private void GenerateObstacles()
    {
        // Validate input
        if (obstaclePrefabs == null || obstaclePrefabs.Length == 0)
        {
            Debug.LogError("No obstacle prefabs assigned!");
            return;
        }

        if (obstacleCount <= 0)
        {
            Debug.LogError("Obstacle count must be greater than 0!");
            return;
        }

        // Generate obstacles
        for (int i = 0; i < obstacleCount; i++)
        {
            // Select a random prefab
            GameObject prefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];

            // Generate a random position
            float randomX = Random.Range(minPosition.x, maxPosition.x);
            float randomY = Random.Range(minPosition.y, maxPosition.y);
            Vector3 randomPosition = new Vector3(randomX, randomY, 0f);

            // Instantiate the obstacle
            if (prefab != null)
            {
                GameObject instance = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                instance.transform.position = randomPosition;
                Undo.RegisterCreatedObjectUndo(instance, "Create Obstacle");
            }
        }

        Debug.Log($"Generated {obstacleCount} obstacles successfully!");
    }
}

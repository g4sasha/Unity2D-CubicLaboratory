using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _blockPrefab;
    [SerializeField] private Transform _levelGroup;
    [SerializeField] private Camera _camera;
    [SerializeField] private uint _worldWidth, _worldHeight;

    private List<GameObject> _blocks = new List<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < _worldWidth; i++)
        {
            for (int j = 0; j < _worldHeight; j++)
            {
                GameObject _newBlock = Instantiate(_blockPrefab, new Vector2(i - _camera.orthographicSize * _camera.aspect, j - _camera.orthographicSize), Quaternion.identity);
                _blocks.Add(_newBlock);
                _newBlock.transform.SetParent(_levelGroup);
            }
        }
    }
}
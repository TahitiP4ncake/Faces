using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceGenerator : MonoBehaviour
{
    public Part[] parts;

    public GameObject[] eyes;
    public GameObject[] noses;
    public GameObject[] mouths;

    public float etrange;
    
    public List<GameObject> activeFace = new List<GameObject>();
    
    void Start()
    {
        GenerateFace();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ClearFace();
            GenerateFace();
        }
    }

    void GenerateFace()
    {

        foreach (var part in parts)
        {
            part.Generate();
        }
        
    }

    public void AddPart(GameObject part, Transform _trans, bool _flip = false)
    {
        GameObject _part = Instantiate(part, _trans);
        _part.transform.localPosition = Vector3.zero;

        if (_flip)
        {
            _part.transform.localScale = new Vector3(-1,1,1);
        }
        activeFace.Add(_part);
    }

    void ClearFace()
    {
        foreach (var _face in activeFace)
        {
            Destroy(_face);
        }
        
        activeFace.Clear();
    }
}

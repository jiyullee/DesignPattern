using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    //외부 상태
    public class Tree
    {
        TreeModel _model;
        Vector2 _position;
        double _height;
        double _thickness;
        Color _barkTint;
        Color _leafTint;
    }

    //숲에서는 비슷해 보이는 나무를 같은 클래스로 묶는다. 고유 상태, 자유 문맥 상태
    public class TreeModel
    {
        private Mesh _mesh;
        Texture _bark;
        Texture _sleaves;
    }
}

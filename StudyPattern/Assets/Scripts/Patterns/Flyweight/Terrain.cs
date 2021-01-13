using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class Terrain
    {
        private int _movementCost;
        private bool _isWater;
        Texture _texture;

        public Terrain(int movementCost, bool isWater, Texture texture)
        {
            _movementCost = movementCost;
            _isWater = isWater;
            _texture = texture;
        }

        int GetMovementCost => _movementCost;
        bool IsWater => _isWater;
        Texture GetTexture => _texture;
    }
}

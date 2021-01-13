using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flyweight
{
    public class World
    {
        const int WIDTH = 10;
        const int HEIGHT = 10;

        Texture GRASS_TEXTURE;
        Texture HILL_TEXTURE;
        Texture RIVER_TEXTURE;

        private Terrain[][] tiles = new Terrain[WIDTH][];

        private Terrain grassTerrain;
        private Terrain hillTerrain;
        private Terrain riverTerrain;

        public World()
        {
            grassTerrain = new Terrain(1, false, GRASS_TEXTURE);
            hillTerrain = new Terrain(3, false, HILL_TEXTURE);
            riverTerrain = new Terrain(2, true, RIVER_TEXTURE);
        }

        void GenerateTerrain()
        {
            //땅에 풀을 채운다.
            for(int x = 0; x < WIDTH; x++)
            {
                tiles[x] = new Terrain[HEIGHT];
                for (int y = 0; y < HEIGHT; y++)
                {
                    if (Random.Range(0, 10) == 0)
                        tiles[x][y] = hillTerrain;
                    else
                        tiles[x][y] = grassTerrain;
                }
            }

            //강을 하나 놓는다.
            int r = Random.Range(0, WIDTH);
            for(int y = 0; y < HEIGHT; y++)
            {
                tiles[r][y] = riverTerrain;
            }
        }

        Terrain GetTile(int x, int y)
        {
            return tiles[x][y];
        }
 
    }
}

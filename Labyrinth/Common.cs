﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//using Game_Labyrinth.Character;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace Labyrinth
{
    public static class C
    {
        //Texture
        public static Texture2D wallTile;
        public static Texture2D grassTile;
        public static Texture2D cannonU;
        public static Texture2D cannonD;
        public static Texture2D cannonL;
        public static Texture2D cannonR;
        public static Texture2D bulletImag;
        public static Texture2D padlockImag;
        //matice del labirinto 
        public static int[,] lbrnt;
        public static int rowsNb, colsNb;

        public static Vector2 DISPLAYDIM = new Vector2(1600, 900);
        public static bool animationOn = false;
        public static Rectangle charRect;
        public static Texture2D charSheetText;
        public static int FRAMEXROW = 4;

        //spritefont
        public static  SpriteFont font;

        public static Texture2D[,] labText;
        public static Point guyPos;
        public static Point movingDir;
        public static float speed;
        public static Point startGuyPos;
        public static Point endGuyPos;
        public static float multFactor = 30;

        public static Random rand = new Random();

        public static Vector2 ORGLAB;
        public static int step = (int) multFactor / FRAMEXROW;
        public static GameStatus gameStatus;
        public static int level = 0;
        public static int MAXLEVEL = 2;

        public static Point PIXELPOINT = new Point(40, 40);
        public static Point WINDOWOFFSET = new Point(100, 50);

        public static int fluid_count;

        public static List<Cannon> listCannon = new List<Cannon>();
        //liste cannoni
        //public static List<Cannon> listCannonL = new List<Cannon>();
        //public static List<Cannon> listCannonR = new List<Cannon>();
        //public static List<Cannon> listCannonU = new List<Cannon>();
        //public static List<Cannon> listCannonD = new List<Cannon>();

        //Liste proiettile
        public static List<Bullet> listBulletL = new List<Bullet>();
        public static List<Bullet> listBulletR = new List<Bullet>();
        public static List<Bullet> listBulletU = new List<Bullet>();
        public static List<Bullet> listBulletD = new List<Bullet>();

        public static List<Life> listLife = new List<Life>();
        public static uint life = 1;

        public static List<Key> listKeys = new List<Key>();
        public static uint keys = 0;

        public static Texture2D cannon;
        public static Texture2D cannons;
        public static Texture2D bullet;
        public static Texture2D bullets;

        //Sound Effect
        public static Song song;
        public static SoundEffect explotionEffect;
        public static SoundEffect keyEffect;
        public static SoundEffect buttonEffect;
        public static SoundEffect openLookEffect;
        public static SoundEffect lifeEffect;

        public static bool isExplotion = false;

        public static string pathBestTime = @"C:\Users\Jorge\Desktop\Labyrinth\Labyrinth-Escape-\Labyrinth\Content\BestScore.txt";
        public static int bestTime;

        public static double timeElapsed;
        public static double finalTime;

        public static bool isBest;


    }
}

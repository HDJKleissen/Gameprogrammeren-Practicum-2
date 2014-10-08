﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System.Diagnostics;
using Microsoft.Xna.Framework.Input;

namespace Practicum2.gameobjects.pieces
{
    class TPiece : Piece
    {
        public TPiece(bool isNextPiece, string id = "", int size = 3, string assetname = "sprites/block"): base(isNextPiece, id, size)
        {
            for (int x = 0; x < 3; x++)
                pieceArray[x, 1] = true;
            pieceArray[1, 2] = true;

            color = Color.Purple;
            pieceType = PieceType.T;
        }
    }
}

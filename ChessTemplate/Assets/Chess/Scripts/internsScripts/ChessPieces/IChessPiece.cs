using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChessPiece 
{
   public ChessPiece.chessPieceColor pieceColor { get; }
    int currentRow { get; }
    int currentCol { get; }

}

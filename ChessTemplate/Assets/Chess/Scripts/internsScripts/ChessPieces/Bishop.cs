using Chess.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessPiece,IChessPiece
{
    public override chessPieceColor pieceColor => chessPieceColor.black;
    protected override void PossibleLegalMoves()
    {
        base.PossibleLegalMoves();
        GameObject currentHighlight;
        for (int i = 0; i < 8; i++)
        {
            if (currentRow + i < 8 && currentCol + i < 8)
            {
                if (currentRow + i == currentRow && currentCol + i == currentCol)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + i, currentCol + i);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight at positive x and y axis of bishop
        for (int i = 0; i < 8; i++) 
        { 
            if (currentRow - i > -1 && currentCol - i > -1)
            {
                if (currentRow - i == currentRow && currentCol - i == currentCol)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - i, currentCol - i);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight at negative x and y axis of bishop
        for (int i = 0; i < 8; i++)
        {
            if (currentRow + i < 8 && currentCol - i > -1)
            {
                if(currentRow+i==currentRow && currentCol-i == currentCol)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + i, currentCol - i);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight at positive x and negative  y axis of bishop
        for (int i = 0; i < 8; i++) 
        { 
            if (currentRow - i > -1 && currentCol + i < 8)
            {
                if(currentRow-i==currentRow && currentCol+i == currentCol)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - i, currentCol + i);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight at negative x and positive y axis of bishop
    }
}

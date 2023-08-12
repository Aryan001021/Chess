using Chess.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessPiece,IChessPiece
{
    public override chessPieceColor pieceColor => chessPieceColor.black;
    protected override void PossibleLegalMoves()
    {
        base.PossibleLegalMoves();
        GameObject currentHighlight;
        for (int i = 0; i < 8; i++)
        {
            if (currentRow + i < 8 && currentRow + i > -1)
            {
                if (currentRow + i == currentRow)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + i, currentCol);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight right side of rook
        for (int i = 0; i < 8; i++)
        {
            if (currentRow - i > -1 && currentRow - i < 8)
            {
                if (currentRow - i == currentRow)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - i, currentCol);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight  left side of rook
        for (int i = 0; i < 8; i++)
        {
            if (currentCol - i > -1 && currentCol + i > -1)
            {
                if (currentCol - i == currentCol)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow, currentCol - i);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight below of rook
        for (int i = 0; i < 8; i++)
        {
            if ((currentCol + i) < 8 && currentCol - i < 8)
            {
                if (currentCol + i == currentCol)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow, currentCol + i);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy(currentHighlight);
                    break;
                }
            }
        }//to put highlight above the rook
    }
}

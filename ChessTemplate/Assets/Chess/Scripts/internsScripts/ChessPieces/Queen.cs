using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessPiece,IChessPiece
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
                if(currentRow + i == currentRow)
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
        }
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
        }
        for (int i = 0; i < 8; i++)
        {
            if (currentCol - i > -1 && currentCol + i > -1)
            {
                if (currentRow - i == currentCol)
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
        }
        for (int i = 0; i < 8; i++)
        {
            if ((currentCol + i) < 8 && currentCol - i < 8)
            {
                if (currentCol - i == currentCol)
                {
                    continue;
                }
                currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow, currentCol + i);
                if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
                {
                    Destroy (currentHighlight);
                    break;
                }
            }
        }
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
        }
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
        }
        for (int i = 0; i < 8; i++)
        {
            if (currentRow + i < 8 && currentCol - i > -1)
            {
                if (currentRow + i == currentRow && currentCol - i == currentCol)
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
        }
        for (int i = 0; i < 8; i++)
        {
            if (currentRow - i > -1 && currentCol + i < 8)
            {
                if (currentRow - i == currentRow && currentCol + i == currentCol)
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
        }
    }// this is sum of same function of bishop and rook
}

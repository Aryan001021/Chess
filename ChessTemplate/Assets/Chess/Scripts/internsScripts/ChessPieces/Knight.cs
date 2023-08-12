using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessPiece,IChessPiece
{
    public override chessPieceColor pieceColor => chessPieceColor.black;

    protected override void PossibleLegalMoves()
    {
        base.PossibleLegalMoves();
        GameObject currentHighlight;
        if (currentRow + 1 < 8 && currentCol + 2 < 8)
        {
            currentHighlight=ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol + 2);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentRow + 1 < 8 && currentCol - 2 > -1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol - 2);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentRow + 2 < 8 && currentCol + 1 < 8)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + 2, currentCol + 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentRow + 2 < 8 && currentCol - 1 >-1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + 2, currentCol - 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentRow - 2 > -1 && currentCol + 1 < 8)
        {
            currentHighlight= ChessBoardPlacementHandler.Instance.Highlight(currentRow -2 , currentCol + 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentRow -2 >-1 && currentCol - 1 > -1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - 2, currentCol - 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentRow -1 > -1 && currentCol + 2 < 8)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - 1, currentCol + 2);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentRow -1 > -1 && currentCol - 2 > -1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - 1, currentCol - 2);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessPiece,IChessPiece
{
    public override chessPieceColor pieceColor => chessPieceColor.black;

    protected override void PossibleLegalMoves()
    {
        base.PossibleLegalMoves();
        GameObject currentHighlight;
        if (currentRow + 1 < 8)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//to put highlight to right
        if (currentRow - 1 > -1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - 1, currentCol);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//to put highlight to left
        if (currentCol + 1 < 8)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow, currentCol + 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//to put highlight to top
        if (currentCol - 1 > -1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow, currentCol - 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//to put highlight to bottom
        if (currentCol + 1 < 8 && currentRow + 1 < 8)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol + 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//to put highlight to top right
        if (currentRow - 1 > -1 && currentCol - 1 > -1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - 1, currentCol - 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//to put highlight to left below
        if (currentRow + 1 < 8 && currentCol - 1 > -1)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol - 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//to put highlight to right bellow
        if (currentRow - 1 > -1 && currentCol + 1 < 8)
        {
            currentHighlight = ChessBoardPlacementHandler.Instance.Highlight(currentRow - 1, currentCol + 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }////to put highlight to left above
    }
}

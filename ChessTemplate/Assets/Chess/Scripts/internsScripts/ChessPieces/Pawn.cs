using Chess.Scripts.Core;
using UnityEngine;

public class Pawn : ChessPiece,IChessPiece
{
    public override chessPieceColor pieceColor => chessPieceColor.black;
    protected override void PossibleLegalMoves()
    {
        base.PossibleLegalMoves();
        GameObject currentHighlight;
        currentHighlight= ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol);
        if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
        {
            Destroy(currentHighlight);
        }
        if (currentRow == 1)
        {
            currentHighlight=ChessBoardPlacementHandler.Instance.Highlight(currentRow + 2, currentCol);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }
        if (currentCol - 1 >= 0)
        {
            currentHighlight=ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol - 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.white)
            {
            }
            else
            {
                Destroy(currentHighlight);
            }
        }
        if (currentCol + 1 < 8)
        {
            currentHighlight=ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol + 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.white)
            {
            }
            else
            {
                Destroy(currentHighlight);
            }
        }
    }


}
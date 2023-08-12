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
        }//the step above pawn
        if (currentRow == 1)
        {
            currentHighlight=ChessBoardPlacementHandler.Instance.Highlight(currentRow + 2, currentCol);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.black)
            {
                Destroy(currentHighlight);
            }
        }//if player is on row  1 then 2 steps ahead of pawn
        if (currentCol - 1 >= 0)
        {
            currentHighlight=ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol - 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.white)
            {
                currentHighlight.GetComponent<Highlight>().ColorChange();//change highlight color to red for pawn 
            }
            else
            {
                Destroy(currentHighlight);
            }
        }//the upper left step if enemy is there
        if (currentCol + 1 < 8)
        {
            currentHighlight=ChessBoardPlacementHandler.Instance.Highlight(currentRow + 1, currentCol + 1);
            if (currentHighlight.GetComponent<Highlight>().CollisionCheck() == chessPieceColor.white)
            {
                currentHighlight.GetComponent<Highlight>().ColorChange();//change highlight color to red for pawn
            }
            else
            {
                Destroy(currentHighlight);
            }
        }//the upper right step if enemy is there
    }


}
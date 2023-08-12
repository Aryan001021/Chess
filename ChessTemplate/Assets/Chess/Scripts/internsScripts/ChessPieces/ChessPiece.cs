using Chess.Scripts.Core;
using UnityEngine;
//this class is inherited by all the chess pieces class
public class ChessPiece : MonoBehaviour
{
    public int currentRow { get; private set; }//the row of current piece
    public int currentCol { get; private set; }//the column of current piece
    protected ChessPlayerPlacementHandler playerPlacementHandler;//script for  row and column
    public enum chessPieceColor
    {
        white,black,nullCondition,
    }//type of pieces
    protected virtual void Start()
    {
        playerPlacementHandler = GetComponent<ChessPlayerPlacementHandler>();
    }
    public virtual chessPieceColor pieceColor { get; private set; }
    protected void OnMouseDown()
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
        PossibleLegalMoves();
    }//tho select the chess piece

    protected virtual void PossibleLegalMoves()
    {
        currentCol = playerPlacementHandler.column;
        currentRow = playerPlacementHandler.row;
    }//default implementation of possible moves of a piece will extend by the class it is inherited
}

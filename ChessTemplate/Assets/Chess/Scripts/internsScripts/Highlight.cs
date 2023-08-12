using Chess.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public ChessPiece.chessPieceColor CollisionCheck()
    {
        RaycastHit2D ray;
        if  (Physics2D.Raycast(transform.position,Vector3.zero))
        {
            ray = Physics2D.Raycast(transform.position, Vector3.zero);
            ray.collider.gameObject.TryGetComponent(out IChessPiece piece);
            if (piece != null)
            {
                return piece.pieceColor;
            }
            else
            {
                return ChessPiece.chessPieceColor.nullCondition;
            }
        }
        else
        {
            return ChessPiece.chessPieceColor.nullCondition;
        }
    }//to check if the highlight is colliding with black or white piece.
    public void ColorChange()
    {
        transform.gameObject.GetComponent<SpriteRenderer>().color=Color.red;
    }//to change color for enemy piece
}

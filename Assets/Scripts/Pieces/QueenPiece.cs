﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenPiece : ChessPiece
{
    public override bool[,] PossibleMove()
    {
        bool[,] possibleMovesMap = new bool[8, 8];


        ChessPiece enemyPiece;
        
        int amountOfMovesInXDirection;

        //up
        amountOfMovesInXDirection = CurrentZ;
        while (true)
        {
            amountOfMovesInXDirection++;
            if (amountOfMovesInXDirection >= 8)
            {
                break;
            }


            enemyPiece = BoardManager.Instance.chessPieces[CurrentX, amountOfMovesInXDirection];
            if (enemyPiece == null)
            {
                possibleMovesMap[CurrentX, amountOfMovesInXDirection] = true;
            }
            else
            {
                //if it is an enemy piece
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[CurrentX, amountOfMovesInXDirection] = true;
                }
                break;
            }
        }
        //down
        amountOfMovesInXDirection = CurrentZ;
        while (true)
        {
            amountOfMovesInXDirection--;
            if (amountOfMovesInXDirection < 0)
            {
                break;
            }


            enemyPiece = BoardManager.Instance.chessPieces[CurrentX, amountOfMovesInXDirection];
            if (enemyPiece == null)
            {
                possibleMovesMap[CurrentX, amountOfMovesInXDirection] = true;
            }
            else
            {
                //if it is an enemy piece
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[CurrentX, amountOfMovesInXDirection] = true;
                }
                break;
            }
        }
        //right
        amountOfMovesInXDirection = CurrentX;
        while (true)
        {
            amountOfMovesInXDirection++;
            if (amountOfMovesInXDirection >= 8)
            {
                break;
            }


            enemyPiece = BoardManager.Instance.chessPieces[amountOfMovesInXDirection, CurrentZ];
            if (enemyPiece == null)
            {
                possibleMovesMap[amountOfMovesInXDirection, CurrentZ] = true;
            }
            else
            {
                //if it is an enemy piece
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[amountOfMovesInXDirection, CurrentZ] = true;
                }
                break;
            }
        }
        //left
        amountOfMovesInXDirection = CurrentX;
        while (true)
        {
            amountOfMovesInXDirection--;
            if (amountOfMovesInXDirection < 0)
            {
                break;
            }
            enemyPiece = BoardManager.Instance.chessPieces[amountOfMovesInXDirection, CurrentZ];
            if (enemyPiece == null)
            {
                possibleMovesMap[amountOfMovesInXDirection, CurrentZ] = true;
            }
            else
            {
                //if it is an enemy piece
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[amountOfMovesInXDirection, CurrentZ] = true;
                }
                break;
            }
        }



        //bishop part
        
        int posX;
        int posZ;

        //diagonals
        posX = CurrentX;
        posZ = CurrentZ;
        //upper right diagonal
        while (posX < 7 && posZ < 7)
        {
            posX++;
            posZ++;
            enemyPiece = BoardManager.Instance.chessPieces[posX, posZ];
            if (enemyPiece == null)
            {
                possibleMovesMap[posX, posZ] = true;
            }
            else
            {
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[posX, posZ] = true;
                }
                break;
            }
        }
        posX = CurrentX;
        posZ = CurrentZ;
        //upper left diagonal
        while (posX > 0 && posZ < 7)
        {
            posX--;
            posZ++;
            enemyPiece = BoardManager.Instance.chessPieces[posX, posZ];
            if (enemyPiece == null)
            {
                possibleMovesMap[posX, posZ] = true;
            }
            else
            {
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[posX, posZ] = true;
                }
                break;
            }
        }
        posX = CurrentX;
        posZ = CurrentZ;
        //lower left diagonal
        while (posX > 0 && posZ > 0)
        {
            posX--;
            posZ--;
            enemyPiece = BoardManager.Instance.chessPieces[posX, posZ];
            if (enemyPiece == null)
            {
                possibleMovesMap[posX, posZ] = true;
            }
            else
            {
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[posX, posZ] = true;
                }
                break;
            }
        }
        posX = CurrentX;
        posZ = CurrentZ;
        //lower right diagonal
        while (posX < 7 && posZ > 0)
        {
            posX++;
            posZ--;
            enemyPiece = BoardManager.Instance.chessPieces[posX, posZ];
            if (enemyPiece == null)
            {
                possibleMovesMap[posX, posZ] = true;
            }
            else
            {
                if (enemyPiece.isWhite != isWhite)
                {
                    possibleMovesMap[posX, posZ] = true;
                }
                break;
            }
        }


        return possibleMovesMap;
    }
}

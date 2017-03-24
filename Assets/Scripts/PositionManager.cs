// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PositionManager.cs company=League of HTC Vive Developers>
/*
11111111111111111111111111111111111111001111111111111111111111111
11111111111111111111111111111111111100011111111111111111111111111
11111111111111111111111111111111100001111111111111111111111111111
11111111111111111111111111111110000111111111111111111111111111111
11111111111111111111111111111000000111111111111111111111111111111
11111111111111111111111111100000011110001100000000000000011111111
11111111111111111100000000000000000000000000000000011111111111111
11111111111111110111000000000000000000000000000011111111111111111
11111111111111111111111000000000000000000000000000000000111111111
11111111111111111110000000000000000000000000000000111111111111111
11111111111111111100011100000000000000000000000000000111111111111
11111111111111100000110000000000011000000000000000000011111111111
11111111111111000000000000000100111100000000000001100000111111111
11111111110000000000000000001110111110000000000000111000011111111
11111111000000000000000000011111111100000000000000011110001111111
11111110000000011111111111111111111100000000000000001111100111111
11111111000001111111111111111111110000000000000000001111111111111
11111111110111111111111111111100000000000000000000000111111111111
11111111111111110000000000000000000000000000000000000111111111111
11111111111111111100000000000000000000000000001100000111111111111
11111111111111000000000000000000000000000000111100000111111111111
11111111111000000000000000000000000000000001111110000111111111111
11111111100000000000000000000000000000001111111110000111111111111
11111110000000000000000000000000000000111111111110000111111111111
11111100000000000000000001110000001111111111111110001111111111111
11111000000000000000011111111111111111111111111110011111111111111
11110000000000000001111111111111111100111111111111111111111111111
11100000000000000011111111111111111111100001111111111111111111111
11100000000001000111111111111111111111111000001111111111111111111
11000000000001100111111111111111111111111110000000111111111111111
11000000000000111011111111111100011111000011100000001111111111111
11000000000000011111111111111111000111110000000000000011111111111
11000000000000000011111111111111000000000000000000000000111111111
11001000000000000000001111111110000000000000000000000000001111111
11100110000000000001111111110000000000000000111000000000000111111
11110110000000000000000000000000000000000111111111110000000011111
11111110000000000000000000000000000000001111111111111100000001111
11111110000010000000000000000001100000000111011111111110000001111
11111111000111110000000000000111110000000000111111111110110000111
11111110001111111100010000000001111100000111111111111111110000111
11111110001111111111111110000000111111100000000111111111111000111
11111111001111111111111111111000000111111111111111111111111100011
11111111101111111111111111111110000111111111111111111111111001111
11111111111111111111111111111110001111111111111111111111100111111
11111111111111111111111111111111001111111111111111111111001111111
11111111111111111111111111111111100111111111111111111111111111111
11111111111111111111111111111111110111111111111111111111111111111
*/
//   
// </copyright>
// <summary>
//  Chinese Chess VR
// </summary>
// <author>胡良云（CloudHu）</author>
//中文注释：胡良云（CloudHu） 3/24/2017

// --------------------------------------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// FileName: PositionManager.cs
/// Author: 胡良云（CloudHu）
/// Corporation: 
/// Description: 控制棋盘上的每个位置
/// DateTime: 3/24/2017
/// </summary>
public class PositionManager : MonoBehaviour {
	
	#region Public Variables  //公共变量区域
	
	
	#endregion


	#region Private Variables   //私有变量区域
	

	#endregion
	
	
	#region MonoBehaviour CallBacks //回调函数区域
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	#endregion
	
	#region Public Methods	//公共方法区域

	/// <summary>
	/// 能否移动将帅.
	/// </summary>
	/// <returns><c>true</c>, 如果可以移动, <c>false</c> otherwise.</returns>
	public static bool canMoveKing(int selectedId,int Row,int col,int destoryId){
		/*
		1.将帅被限制在九宫格内移动
		2.移动的步长为一格
		3.将帅不能在一条直线上面对面（中间无棋子遮挡）,如一方占据中路三线中的一线,在无遮挡的情况下,另一方必须回避该线,否则会被对方秒杀
		*/
		if (destoryId!=-1 && ChessmanManager.chessman[destoryId]._type==ChessmanManager.Chessman.TYPE.KING) {
			return false;
		}
		return true;
	}
	
	#endregion
	
}

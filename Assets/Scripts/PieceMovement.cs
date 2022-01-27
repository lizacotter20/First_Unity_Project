using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Random;

public class PieceMovement : MonoBehaviour
{
	int[,] grid = new int[10, 8];
	
	private float[,,] piece_array = new float[3,3,2] { { { -2 * tileSize + tileSize/2, 7*tileSize}, { -1 * tileSize + tileSize/2, 7*tileSize}, {tileSize - tileSize/2, 7*tileSize}},
				                                       { { -2 * tileSize + tileSize/2, 6*tileSize}, { -1 * tileSize + tileSize/2, 6*tileSize}, {tileSize - tileSize/2, 6*tileSize}},
				                                       { { -2 * tileSize + tileSize/2, 5*tileSize}, { -1 * tileSize + tileSize/2, 5*tileSize}, {tileSize - tileSize/2, 5*tileSize}}};

	Dictionary<int, float[]> gridMap = new Dictionary<int, float[]>();
		                                      	
	private const float tileSize = 0.65f;
	//public GameObject blue_square_2;
	//public GameObject purple_square_4;

	private int piece;

    // Start is called before the first frame update
    void Start()
    {
    	int k = 0;
	    for (int i = 0; i <= 2; i++){
	    	for (int j = 0; j <= 2; j++){
	    		float[] temp = new float[] {piece_array[i,j,0], piece_array[i,j,1]};
				gridMap.Add(k+1, temp);
				k++;
			}
		}	
    	piece = ShowPiece();
    }

    // Update is called once per frame
    void Update()
    {
    	//Debug.Log("update PM");
        if (Input.GetKeyDown("space")){
        	//Debug.Log("got in if");
        	//UpdateGrid(piece);
        	piece = ShowPiece();


        }
        if (Input.GetKeyDown("down")){ //counter clockwise rotation

        }
        if (Input.GetKeyDown("up")){ //clockwise rotation
        	//float[] new_pos =  UpdatePos(1);

        }
        if (Input.GetKeyDown("right")){ // shift right

        }
        if (Input.GetKeyDown("left")){ //shift left

        }

    }

    private int ShowPiece()
    {
    	Debug.Log("In show piece");
    	int num = Random.Range(0,2);
    	//int num =0;
    	Debug.Log(num.ToString());
    	GameObject referenceTile = (GameObject)Instantiate(Resources.Load("blue_square_2"));
    	Vector2 pos1 = new Vector2(0,0), pos2 = new Vector2(0,0), pos3 = new Vector2(0,0), pos4 = new Vector2(0,0);
    		
    	if (num == 0){	//long light blue piece

    		referenceTile = (GameObject)Instantiate(Resources.Load("blue_square_2"));

    		pos1 = new Vector2(piece_array[1,0,0], piece_array[1,0,1]);
    		pos2 = new Vector2(piece_array[1,1,0], piece_array[1,1,1]);
    		pos3 = new Vector2(piece_array[1,2,0], piece_array[1,2,1]);
    		pos4 = new Vector2(2 *pos3.x- pos2.x, 2 *pos3.y- pos2.y);

    	}
    	if (num == 1){	//purple t piece

    		referenceTile = (GameObject)Instantiate(Resources.Load("purple_square_4"));

    		pos1 = new Vector2(piece_array[1,0,0], piece_array[1,0,1]);
    		pos2 = new Vector2(piece_array[1,1,0], piece_array[1,1,1]);
    		pos3 = new Vector2(piece_array[0,1,0], piece_array[0,1,1]);
    		pos4 = new Vector2(piece_array[1,2,0], piece_array[1,2,1]);
    	
    	}

    	GameObject sq1 = (GameObject)Instantiate(referenceTile, transform);
		GameObject sq2 = (GameObject)Instantiate(referenceTile, transform);
		GameObject sq3 = (GameObject)Instantiate(referenceTile, transform);
		GameObject sq4 = (GameObject)Instantiate(referenceTile, transform);

		sq1.transform.position = pos1;
		sq2.transform.position = pos2;
		sq3.transform.position = pos3;
		sq4.transform.position = pos4;
	
    	//Destroy(referenceTile);
    	return num;
    }
    /*

    private void UpdateGrid(int piece)
    {

    }
    */
/*
    private float[] UpdatePos(int move){

    	if(move == 1){

    		Vector2 current_pos = sq1.position; 
    		sq1.transform.position = new Vector2(posX, posY);
    	}

    }
    */
    
}

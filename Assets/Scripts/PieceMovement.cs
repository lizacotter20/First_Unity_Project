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

	Dictionary<int, int[]> gridMap = new Dictionary<int, int[>();

	// Add some elements to the dictionary. There are no
	// duplicate keys, but some of the values are duplicates.
	for (int i = 0; i <= 2; i++)
	openWith.Add("txt", "notepad.exe");
	openWith.Add("bmp", "paint.exe");
	openWith.Add("dib", "paint.exe");
	openWith.Add("rtf", "wordpad.exe");			                                      
		
	private const float tileSize = 0.65f;
	//public GameObject blue_square_2;
	//public GameObject purple_square_4;



	private int piece;

    // Start is called before the first frame update
    void Start()
    {
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
        	float[] new_pos =  UpdatePos(1);

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

    
    	if (num == 0){	//long light blue piece

    		GameObject referenceTile = (GameObject)Instantiate(Resources.Load("blue_square_2"));

    		Vector2 pos1 = new Vector2(piece_array[1,0,0], piece_array[1,0,1]);
    		Vector2 pos2 = new Vector2(piece_array[1,1,0], piece_array[1,1,1]);
    		Vector2 pos3 = new Vector2(piece_array[1,2,0], piece_array[1,2,1]);
    		Vector2 pos4 = new Vector2(2 *pos3.x- pos2.x, 2 *pos3.y- pos2.y);

    	}
    	if (num == 1){	//purple t piece

    		GameObject referenceTile = (GameObject)Instantiate(Resources.Load("purple_square_4"));

    		Vector2 pos1 = new Vector2(piece_array[1,0,0], piece_array[1,0,1]);
    		Vector2 pos2 = new Vector2(piece_array[1,1,0], piece_array[1,1,1]);
    		Vector2 pos3 = new Vector2(piece_array[0,1,0], piece_array[0,1,1]);
    		Vector2 pos4 = new Vector2(piece_array[1,2,0], piece_array[1,2,1]);
    	
    	}

    	GameObject sq1 = Instantiate(referenceTile, pos1);
		GameObject sq2 = Instantiate(referenceTile, pos2);
		GameObject sq3 = Instantiate(referenceTile, pos3);
		GameObject sq4 = Instantiate(referenceTile, pos4);
	
    	//Destroy(referenceTile);
    	return num;
    }
    /*

    private void UpdateGrid(int piece)
    {

    }
    */

    private float[] UpdatePos(int move){

    	if(move == 1){

    		Vector2 current_pos = sq1.position; 
    		sq1.transform.position = new Vector2(posX, posY);
    	}

    }
    
}

package pacman.gui;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.Rectangle;
import java.util.ArrayList;
import java.util.List;


public class Maze {
	
	private final int fieldSize = 30;
	private final int fieldNumberHor = 20;
	private final int fieldNumberVer = 21;
	private List<Rectangle> rectWall = new ArrayList<Rectangle>();
	private List<Rectangle> rectCoin = new ArrayList<Rectangle>();
	
	public final int mazeData[][] = {
			{0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
	        {0, 19, 26, 26, 18, 26, 26, 26, 22,  0,  0, 19, 26, 26, 26, 18, 26, 26, 22,  0},
	        {0, 21,  0,  0, 21,  0,  0,  0, 21,  0,  0, 21,  0,  0,  0, 21,  0,  0, 21,  0},
	        {0, 17, 26, 26, 16, 26, 18, 26, 24, 26, 26, 24, 26, 18, 26, 16, 26, 26, 20,  0},
	        {0, 21,  0,  0, 21,  0, 21,  0,  0,  0,  0,  0,  0, 21,  0, 21,  0,  0, 21,  0},
	        {0, 25, 26, 26, 20,  0, 25, 26, 22,  0,  0, 19, 26, 28,  0, 17, 26, 26, 28,  0},
	        {0,  0,  0,  0, 21,  0,  0,  0, 21,  0,  0, 21,  0,  0,  0, 21,  0,  0,  0,  0},
	        {0,  0,  0,  0, 21,  0, 19, 26, 24, 18, 18, 24, 26, 22,  0, 21,  0,  0,  0,  0},
	        {0,  0,  0,  0, 21,  0, 21,  0, 50, 50, 50, 50,  0, 21,  0, 21,  0,  0,  0,  0},
	        {0,  0,  0,  0, 17, 26, 20,  0, 50, 50, 50, 50,  0, 17, 26, 20,  0,  0,  0,  0},
	        {0,  0,  0,  0, 21,  0, 21,  0,  0,  0,  0,  0,  0, 21,  0, 21,  0,  0,  0,  0},
	        {0,  0,  0,  0, 21,  0, 17, 26, 26, 26, 26, 26, 26, 20,  0, 21,  0,  0,  0,  0},
	        {0,  0,  0,  0, 21,  0, 21,  0,  0,  0,  0,  0,  0, 21,  0, 21,  0,  0,  0,  0},
	        {0, 19, 26, 26, 50, 26, 24, 26, 22,  0,  0, 19, 26, 24, 26, 16, 26, 26, 22,  0},
	        {0, 21,  0,  0, 21,  0,  0,  0, 21,  0,  0, 21,  0,  0,  0, 21,  0,  0, 21,  0},
	        {0, 25, 22,  0, 17, 26, 18, 26, 24, 26, 26, 24, 26, 18, 26, 20,  0, 19, 22,  0},
	        {0,  0, 21,  0, 21,  0, 21,  0,  0,  0,  0,  0,  0, 21,  0, 21,  0, 21,  0,  0},
	        {0, 19, 24, 26, 28,  0, 25, 26, 22,  0,  0, 19, 26, 28,  0, 25, 26, 24, 22,  0}, 
	        {0, 21,  0,  0,  0,  0,  0,  0, 21,  0,  0, 21,  0,  0,  0,  0,  0,  0, 21,  0},
	        {0, 25, 26, 26, 26, 26, 26, 26, 24, 26, 26, 24, 26, 26, 26, 26, 26, 26, 28,  0},
	        {0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0},
	};
	
	public int screenMaze[][] = new int[fieldNumberVer][fieldNumberHor];
	
	public Maze() {
		
		setScreenMaze();
	}
	
	public void render(Graphics g) {
	
		for(int a = 0; a < fieldNumberVer; a++) {
			for(int b = 0; b < fieldNumberHor; b++) {
				
				g.setColor(new Color(22, 26, 224));
				
				if(screenMaze[a][b] == 0) {
					g.fillRect(b * fieldSize + 7, a * fieldSize + 155, fieldSize, fieldSize);
				}
				if (screenMaze[a][b] > 0 && screenMaze[a][b] < 31) { 
                    g.setColor(new Color(255,255,255));
                    g.fillRect(b * fieldSize + 7 + 15, a * fieldSize + 155 + 15, 6, 6);
                }
			}	
		}
	}
	
	public void setScreenMaze() {
		
		rectWall.clear();
		rectCoin.clear();
		
		for(int i = 0; i < fieldNumberVer; i++) {
			for(int j = 0; j < fieldNumberHor; j++) {
				screenMaze[i][j] = mazeData[i][j];
			}
		}
		
		//rectCoin.add(new Rectangle(1 * fieldSize + 7 + 15, 1 * fieldSize + 155 + 15, 6, 6));
		
		for(int a = 0; a < fieldNumberVer; a++) {
			for(int b = 0; b < fieldNumberHor; b++) {
				
				if(screenMaze[a][b] == 0) {
					rectWall.add(new Rectangle(b * fieldSize + 7, a * fieldSize + 155, fieldSize, fieldSize));
				}
				if (screenMaze[a][b] > 0 && screenMaze[a][b] < 31) {
                    rectCoin.add(new Rectangle(b * fieldSize + 7 + 15, a * fieldSize + 155 + 15, 6, 6));
                }
			}	
		}
	}
	
	public int getFieldSize() {
		return fieldSize;
	}
	
	public int getfieldNumberHor() {
		return fieldNumberHor;
	}
	
	public int getfieldNumberVer() {
		return fieldNumberVer;
	}
	
	public int[][] getScreenMaze() {
		return screenMaze;
	}
	
	public int getScreenMazeElement(int x, int y) {
		return screenMaze[y][x];
	}
	
	public void setScreenMazeElement(int x, int y, int element) {
		screenMaze[y][x] = element;
	}
	
	public List<Rectangle> getRectWall() {
		return rectWall;
	}
	
	public List<Rectangle> getRectCoin() {
		return rectCoin;
	}
}

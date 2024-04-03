package pacman.gui;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.image.ImageObserver;

import javax.swing.ImageIcon;

import pacman.game.Game;
import pacman.game.Handler;
import pacman.game.STATE;

public class HUD implements ImageObserver{
	
	public static int score;
	public static int lives;
	private int maxCoinNumber;
	private Maze maze;
	private Image heart;
	private Handler handler;
	private Game game;
	
	public HUD(Maze maze, Handler handler, Game game) {
		score = 0;
		lives = 3;
		this.maze = maze;
		this.handler = handler;
		this.game = game;
		maxCoinNumber = maze.getRectCoin().size();
		
		heart = new ImageIcon("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\images\\heart.png").getImage();
	}
	
	public void tick() {
		
		int currentCoinNUmber = maze.getRectCoin().size();
		score = (maxCoinNumber - currentCoinNUmber) * 10;
		if(game.gameState == STATE.Dead) {
			for(int i = 0; i < handler.objects.size(); i++) {
				handler.objects.get(i).setSpeedX(0);
				handler.objects.get(i).setSpeedY(0);
			}
		}
		
		if(maze.getRectCoin().size() == 0) {
			game.gameState = STATE.Win;
			for(int i = 0; i < handler.objects.size(); i++) {
				handler.objects.get(i).setSpeedX(0);
				handler.objects.get(i).setSpeedY(0);
			}	
		}		
	}
	
	public void render(Graphics g) {
		Font fnt = new Font("arial", 1, 20);
		
		g.setFont(fnt);
		g.setColor(Color.white);
		g.drawString("Score: " + score, 20, 100);
		
		g.drawString("Lives: ", 20, 135);
		switch(lives) {
			case 0 :
				game.gameState = STATE.Dead;
				Font fnt2 = new Font("arial", 1, 70);
				
				g.setFont(fnt2);
				g.setColor( new Color(181, 0, 0));
				g.drawString("GAME OVER", 90, 400);
				
				Font fnt3 = new Font("arial", 1, 30);
				g.setFont(fnt3);
				g.setColor(Color.yellow);
				g.drawString("Press 'Space' to continue.", 120, 770);
				break;
			case 1 :
				g.drawImage(heart, 85, 117, this);
				break;
			case 2 :
				g.drawImage(heart, 85, 117, this);
				g.drawImage(heart, 115, 117, this);
				break;
			case 3 :
				g.drawImage(heart, 85, 117, this);
				g.drawImage(heart, 115, 117, this);
				g.drawImage(heart, 145, 117, this);
				break;
			default :
				break;
		}
		
		if(game.gameState == STATE.Win) {
			Font fnt2 = new Font("arial", 1, 70);
			
			g.setFont(fnt2);
			g.setColor( new Color(0, 255, 64));
			g.drawString("YOU WON", 135, 400);
			
			Font fnt3 = new Font("arial", 1, 30);
			g.setFont(fnt3);
			g.setColor(Color.yellow);
			g.drawString("Press 'Space' to continue.", 120, 770);
		}
		
	}
	
	public static void setLives(int i) {
		HUD.lives = i;
	}

	public static void setScore(int i) {
		HUD.score = i;
	}
	
	public int getScore() {
		return HUD.score;
	}
	
	@Override
	public boolean imageUpdate(Image img, int infoflags, int x, int y, int width, int height) {
		return true;
	}
}

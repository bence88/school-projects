package pacman.game;

import java.awt.Graphics;
import java.awt.Image;
import java.awt.Rectangle;
import java.awt.image.ImageObserver;

import javax.swing.ImageIcon;

import pacman.gui.HUD;
import pacman.gui.Maze;

public class PacMan extends GameObject implements ImageObserver{
	
	private Image down;
	private Image up;
	private Image right;
	private Image left;
	private Image pacman;
	
	private Handler handler;
	private int startX, startY;
	

	public PacMan(int x, int y, GameObjectID id, Maze maze, Handler handler) {
		super(x, y, id, maze);
		this.speedX = 0;
		this.handler = handler;
		startX = x;
		startY = y;
		
		down = new ImageIcon("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\images\\down.gif").getImage();
		up = new ImageIcon("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\images\\up.gif").getImage();
		right = new ImageIcon("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\images\\right.gif").getImage();
		left = new ImageIcon("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\images\\left.gif").getImage();
		pacman = new ImageIcon("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\images\\pacman.png").getImage();
	}
	
	@Override
	public Rectangle getBounds() {
		return new Rectangle(x, y, 22, 22);
	}
	
	private void collision() {
		for(int i = 0; i < handler.objects.size(); i++) {
			GameObject tempObject = handler.objects.get(i);
			
			if(tempObject.getID() == GameObjectID.Ghost) {
				if(getBounds().intersects(tempObject.getBounds())) {
					HUD.lives -= 1;
					
					this.speedX = 0;
					this.speedY = 0;
					
					this.x = startX;
					this.y = startY;
				}
			}
		}
	}

	@Override
	public void tick() {		
		
		for(int i = 0; i < maze.getRectWall().size(); i++) {
			if(getBounds().intersects(maze.getRectWall().get(i))) {
				
				this.x -= speedX * 2;
				this.y -= speedY * 2;
				
				this.speedY = 0;
				this.speedX = 0;
				return;
			}
		}
		
		
		for(int i = 0; i < maze.getRectCoin().size(); i++) {
			if(getBounds().intersects(maze.getRectCoin().get(i))) {
				int posX, posY;
				
				posX = (maze.getRectCoin().get(i).x - 7 - 15) / maze.getFieldSize();
				posY = (maze.getRectCoin().get(i).y - 155 - 15) / maze.getFieldSize();
				maze.setScreenMazeElement(posX, posY, 50);
				maze.getRectCoin().remove(i);
			}
		}
		
		x += speedX;
		y += speedY;

		collision();
	}

	@Override
	public void render(Graphics g) {
		if(speedY > 0) {
			g.drawImage(down, x, y, this);
		}else if(speedY < 0) {
			g.drawImage(up, x, y, this);
		}else if(speedX > 0) {
			g.drawImage(right, x, y, this);
		}else if(speedX < 0) {
			g.drawImage(left, x, y, this);
		}else if(speedY == 0 & speedX == 0) {
			g.drawImage(pacman, x, y, this);
		}	
	}

	@Override
	public boolean imageUpdate(Image img, int infoflags, int x, int y, int width, int height) {
		return true;
	}

	
	
}

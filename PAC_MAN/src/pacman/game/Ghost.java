package pacman.game;

import java.awt.Graphics;
import java.awt.Image;
import java.awt.Rectangle;
import java.awt.image.ImageObserver;
import java.util.Random;

import javax.swing.ImageIcon;

import pacman.gui.Maze;

public class Ghost extends GameObject implements ImageObserver{

	private Image ghost;
	private Random rand = new Random();
	private int randDir;

	public Ghost(int x, int y, GameObjectID id, Maze maze) {
		super(x, y, id, maze);
		ghost = new ImageIcon("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\images\\ghost.gif").getImage();
		
		this.speedX = 3;
	}

	@Override
	public void tick() {
		
		for(int i = 0; i < maze.getRectWall().size(); i++) {
			if(getBounds().intersects(maze.getRectWall().get(i))) {
				
				this.x -= speedX * 2;
				this.y -= speedY * 2;
				
				randDir = rand.nextInt(4);
				
				switch(randDir) {
					case 0 :
						this.speedY = 0;
						this.speedX = 3;
						break;
					case 1 :
						this.speedY = 0;
						this.speedX = -3;
						break;
					case 2 :
						this.speedY = 3;
						this.speedX = 0;
						break;
					case 3 :
						this.speedY = -3;
						this.speedX = 0;
						break;
					default :
						break;
				}	
			}
		}
		
		this.x += speedX;
		this.y += speedY;
		
	}

	@Override
	public void render(Graphics g) {
		g.drawImage(ghost, x, y, this);
	}

	@Override
	public Rectangle getBounds() {
		return new Rectangle(x, y, 22, 22);
	}
	
	@Override
	public boolean imageUpdate(Image img, int infoflags, int x, int y, int width, int height) {
		return true;
	}

}

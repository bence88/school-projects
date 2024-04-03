package pacman.game;

import java.awt.Graphics;
import java.awt.Rectangle;

import pacman.gui.Maze;

public abstract class GameObject {
	
	protected int x, y;
	protected GameObjectID id;
	protected int speedX, speedY;
	protected Maze maze;
	
	public GameObject(int x, int y, GameObjectID id, Maze maze) {
		this.x = x;
		this.y = y;
		this.id = id;
		this.maze = maze;
	}
	
	public abstract void tick();
	public abstract void render(Graphics g);
	public abstract Rectangle getBounds();
	
	public void setX(int x) {
		this.x = x;
	}
	
	public void setY(int y) {
		this.y = y;
	}
	
	public int getX() {
		return x;
	}
	
	public int getY() {
		return y;
	}
	
	public void setID(GameObjectID id) {
		this.id = id;
	}
	
	public GameObjectID getID() {
		return id;
	}
	
	public void setSpeedX(int speedX) {
		this.speedX = speedX;
	}
	
	public void setSpeedY(int speedY) {
		this.speedY = speedY;
	}
	
	public int getSpeedX() {
		return speedX;
	}
	
	public int getSpeedY() {
		return speedY;
	}
	
}

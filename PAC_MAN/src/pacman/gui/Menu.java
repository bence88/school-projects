package pacman.gui;

import java.awt.Color;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.TreeMap;

import pacman.game.Container;
import pacman.game.Game;
import pacman.game.GameObjectID;
import pacman.game.Ghost;
import pacman.game.Handler;
import pacman.game.KeyInput;
import pacman.game.PacMan;
import pacman.game.STATE;

public class Menu implements MouseListener, Serializable{

	private static final long serialVersionUID = -5213397367667474126L;
	
	public Map<Integer, String> map = new TreeMap<Integer, String>();
	public Set<Map.Entry<Integer, String> > entrySet;
	List<Map.Entry<Integer, String> > entryList;
	private Game game;
	private Handler handler;
	private Maze maze;
	private String playerName = new String();
	private String temp1, temp2;
	
	public Menu(Game game, Handler h, Maze maze) {
		this.game = game;
		this.handler = h;
		this.maze = maze;
	}
	
	public void setPlayerName(String s) {
		playerName = s;
	}
	
	public String getPlayerName() {
		return this.playerName;
	}
	
	public void tick() {
		if(game.gameState == STATE.Menu) {
			this.map = Container.getMap();
			entrySet  = map.entrySet();
			entryList = new ArrayList<>(entrySet);
		}
	}
	
	public void render(Graphics g) {
		if(game.gameState == STATE.Menu) { // Menu look
			Font fnt = new Font("arial", 1, 50);
			Font fnt2 = new Font("arial", 1, 30);
			
			g.setFont(fnt);
			g.setColor(Color.white);
			g.drawString("Menu", Game.WIDTH / 2 - 70, 175);
			
			g.setFont(fnt2);
			g.setColor(Color.white);
			g.drawRect(Game.WIDTH / 2 - 100, Game.HEIGHT / 2 - 100, 200, 80);
			g.drawString("Play", Game.WIDTH / 2 - 30, 365);
			
			g.setColor(Color.white);
			g.drawRect(Game.WIDTH / 2 - 100, Game.HEIGHT / 2, 200, 80);
			g.drawString("Leaderboard", Game.WIDTH / 2 - 90, 465);
			
			g.setColor(Color.white);
			g.drawRect(Game.WIDTH / 2 - 100, Game.HEIGHT / 2 + 100, 200, 80);
			g.drawString("Quit", Game.WIDTH / 2 - 30, 565);
		}else if(game.gameState == STATE.Leaderboard) { // Leaderboard look
			Font fnt = new Font("arial", 1, 50);
			Font fnt2 = new Font("arial", 1, 25);
			
			g.setFont(fnt);
			g.setColor(Color.white);
			g.drawString("Leaderboard", Game.WIDTH / 2 - 150, 70);
			
			g.setFont(fnt2);
			g.drawRect(Game.WIDTH / 2 + 170, Game.HEIGHT / 2 + 290, 100, 60);
			g.drawString("Back", Game.WIDTH / 2 + 190, Game.HEIGHT / 2 + 328);
			
			g.drawLine(30, 135, Game.WIDTH - 40, 135);
			g.drawString("Name", 150, 130);
			g.drawString("Score", 400, 130);
			
			for(int y = 0; y < map.size(); y++) {
				temp2 = "";
				temp2 += y + 1;
				g.drawString(temp2, 100, 170 + (y * 40));
				g.drawString(entryList.get(y).getValue(), 150, 170 + (y * 40));
				temp1 = "";
				temp1 += entryList.get(y).getKey();
				g.drawString(temp1, 400, 170 + (y * 40));
			}
			
		}else if(game.gameState == STATE.GiveName) {
			
			Font fnt = new Font("arial", 1, 50);
			Font fnt2 = new Font("arial", 1, 25);
			
			g.setFont(fnt);
			g.setColor(Color.white);
			g.drawString("Type in your name!", Game.WIDTH / 2 - 230, 70);
			
			g.setFont(fnt2);
			g.drawRect(Game.WIDTH / 2 + 170, Game.HEIGHT / 2 + 290, 100, 60);
			g.drawString("Back", Game.WIDTH / 2 + 190, Game.HEIGHT / 2 + 328);
			
			g.setFont(fnt2);
			g.drawRect(Game.WIDTH / 2 - 50, Game.HEIGHT / 2 + 290, 100, 60);
			g.drawString("Play", Game.WIDTH / 2 - 25, Game.HEIGHT / 2 + 328);
			
			g.setFont(fnt2);
			g.drawRect(Game.WIDTH / 2 - 100, Game.HEIGHT / 2 - 30, 300, 60);
			g.drawString("Name:", Game.WIDTH / 2 - 200, Game.HEIGHT / 2 + 10);
			g.drawString(playerName, Game.WIDTH / 2 - 100, Game.HEIGHT / 2 + 10);
			
			
		}
	}
	
	private boolean mouseOver(int mx, int my, int x, int y, int width, int height) {
		if(mx > x & mx < x + width) {
			if(my > y & my < y + height) {
				return true;
			}
		}
		return false;
	}

	@Override
	public void mouseClicked(MouseEvent e) {
		
	}

	@Override
	public void mousePressed(MouseEvent e) {
		int mx =  e.getX();
		int my =  e.getY();
		
		if(game.gameState == STATE.Menu) {
			//play button
			if(mouseOver(mx, my, Game.WIDTH / 2 - 100, Game.HEIGHT / 2 - 100, 200, 80)) {
				
				game.gameState = STATE.GiveName;
				
			}
			
			//leaderboard button
			if(mouseOver(mx, my, Game.WIDTH / 2 - 100, Game.HEIGHT / 2, 200, 80)) {
				game.gameState = STATE.Leaderboard;
			}
			
			//quit button
			if(mouseOver(mx, my, Game.WIDTH / 2 - 100, Game.HEIGHT / 2 + 100, 200, 80)) {
				save();
				System.exit(0);
			}
		}
		
		//back button for leaderboard and name typing look
		if(game.gameState == STATE.Leaderboard || game.gameState == STATE.GiveName) {
			if(mouseOver(mx, my, Game.WIDTH / 2 + 170, Game.HEIGHT / 2 + 290, 100, 60)) {
				game.gameState = STATE.Menu;
				playerName = "";
				KeyInput.setPlayerName("");
				return;
			}
		}	
		
		//A "Play" gomb, ami elindítja a játékot
		if(game.gameState == STATE.GiveName) {
			if(mouseOver(mx, my, Game.WIDTH / 2 - 50, Game.HEIGHT / 2 + 290, 100, 60)) {
				
				maze.setScreenMaze();
				
				game.gameState = STATE.Game;
				handler.addGameObject(new PacMan(120 + 10, 390 + 158, GameObjectID.PacMan, maze, handler));
				handler.addGameObject(new Ghost(240 + 10, 270 + 158, GameObjectID.Ghost, maze));
				handler.addGameObject(new Ghost(270 + 10, 270 + 158, GameObjectID.Ghost, maze));
				handler.addGameObject(new Ghost(300 + 10, 270 + 158, GameObjectID.Ghost, maze));
				handler.addGameObject(new Ghost(330 + 10, 270 + 158, GameObjectID.Ghost, maze));
				
			}
		}
		
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		
	}

	@Override
	public void mouseEntered(MouseEvent e) {
		
	}

	@Override
	public void mouseExited(MouseEvent e) {
		
	}
	
	public void load() {
		try {
			FileInputStream f =new FileInputStream("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\leaderboard\\leaderboard.txt");
			ObjectInputStream in =new ObjectInputStream(f);
			Container.treemap = (TreeMap<Integer, String>) in.readObject();
			in.close();
			System.out.println("Leaderboard deszerializálva");
		} catch(IOException ex) {
			ex.printStackTrace();
		} catch(ClassNotFoundException ex) {
			ex.printStackTrace();
		}
	}
	
	public void save() {
		try {
			FileOutputStream f = new FileOutputStream("C:\\Users\\Bence\\eclipse-workspace\\PAC_MAN\\leaderboard\\leaderboard.txt");
			ObjectOutputStream out = new ObjectOutputStream(f);
			out.writeObject(map);
			out.close();
			System.out.println("Leaderboard szerializalva");
			}
			catch(IOException ex) {
				ex.printStackTrace();
			}
	}
	
}

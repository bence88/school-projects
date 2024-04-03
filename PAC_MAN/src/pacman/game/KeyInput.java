package pacman.game;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

import pacman.gui.HUD;
import pacman.gui.Menu;

public class KeyInput implements KeyListener {
	
	private Handler handler;
	private Game game;
	private Menu menu;
	public static String playerName = new String();
	
	
	public KeyInput(Handler handler, Game game, Menu menu) {
		this.handler = handler;
		this.game = game;
		this.menu = menu;
	}
	
	public static void setPlayerName(String s) {
		playerName = s;
	}

	@Override
	public void keyTyped(KeyEvent e) {
		
	}

	@Override
	public void keyPressed(KeyEvent e) {
		int key = e.getKeyCode();
		
		if(game.gameState == STATE.Game) {
			for(int i = 0; i < handler.objects.size(); i++) {
				GameObject tempObject = handler.objects.get(i);
				
				if(tempObject.getID() == GameObjectID.PacMan) {
					
					switch(key) {
						case KeyEvent.VK_W:
							tempObject.setSpeedY(-3);
							tempObject.setSpeedX(0);
							break;
						case KeyEvent.VK_A:
							tempObject.setSpeedX(-3);
							tempObject.setSpeedY(0);
							break;
						case KeyEvent.VK_S:
							tempObject.setSpeedY(3);
							tempObject.setSpeedX(0);
							break;
						case KeyEvent.VK_D:
							tempObject.setSpeedX(3);
							tempObject.setSpeedY(0);
							break;
						default:
							break;
					}
				}
			}
		}
		
		if(game.gameState == STATE.Dead || game.gameState == STATE.Win) {
			if(key == KeyEvent.VK_SPACE) {
				game.gameState = STATE.Menu;
				handler.clearHandler();
				HUD.setLives(3);
				HUD.setScore(0);
			}
		}
		
		if(game.gameState == STATE.GiveName) {
			char c = e.getKeyChar();
			KeyInput.playerName += c;
			menu.setPlayerName(playerName);
		}
		
	}

	@Override
	public void keyReleased(KeyEvent e) {
		
	}
	
	public String getPlayerName() {
		return playerName;
	}

}

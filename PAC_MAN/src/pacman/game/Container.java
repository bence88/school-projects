package pacman.game;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.Collections;
import java.util.Map;
import java.util.TreeMap;

import pacman.gui.HUD;
import pacman.gui.Menu;

public class Container implements Serializable{
	
	private static final long serialVersionUID = 234810526280901003L;

	public static Map<Integer, String> treemap = new TreeMap<Integer, String>(Collections.reverseOrder());
	
	private Menu menu;
	private HUD hud;
	private Game game;
	
	public Container(Menu menu, HUD hud, Game game) {
		this.menu = menu;
		this.hud = hud;
		this.game = game;
	}
	
	public void tick() {
		if(game.gameState == STATE.Win || game.gameState == STATE.Dead) {
			treemap.put(hud.getScore(), menu.getPlayerName());
		}
		
	}
	
	public static Map<Integer, String> getMap(){
		return treemap;
	}
}

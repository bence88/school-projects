package pacman.game;

import java.awt.Canvas;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferStrategy;

import pacman.gui.HUD;
import pacman.gui.Maze;
import pacman.gui.Menu;
import pacman.gui.PacManWindow;

public class Game extends Canvas implements Runnable {
	
	private static final long serialVersionUID = 6475789777233045717L;

	public static final int WIDTH = 630;
	public static final int HEIGHT = 830;
	
	private Thread thread;
	private boolean running = false;
	private Handler handler;
	private Menu menu;
	private Maze maze;
	private HUD hud;
	private Container cont;
	
	public STATE gameState = STATE.Menu;
	
	public Game() {
		handler = new Handler();
		maze = new Maze();
		menu = new Menu(this, handler, maze);
		hud = new HUD(maze, handler, this);
		cont = new Container(menu, hud, this);
		
		menu.load();
		
		this.addKeyListener(new KeyInput(handler, this, menu));
		this.addMouseListener(menu);
		
		new PacManWindow(WIDTH, HEIGHT, "PAC-MAN", this);
	}
	
	public synchronized void start() {
		thread = new Thread(this);
		thread.start();
		running = true;
	}
	
	public synchronized void stop() {	
		try {
			thread.join();
			running = false;
		}catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	public void run() {
		this.requestFocus();
		
		long lastTime = System.nanoTime();
		double amountOfTicks = 60.0;
		double ns = 1000000000 / amountOfTicks;
		double delta = 0;
		long timer = System.currentTimeMillis();
		int frames = 0;
		while(running) {
			long now = System.nanoTime();
			delta += (now - lastTime) / ns;
			lastTime = now;
			if(delta >= 1) {
				tick();
				render();
				frames++;
				delta--;
				if(System.currentTimeMillis() - timer > 1000) {
					System.out.println("FPS: " + frames);
					timer += 1000;
					frames = 0;
				}
			}		
		}
		stop();
	}
	
	private void tick() {
		
		if(gameState == STATE.Game || gameState == STATE.Dead || gameState == STATE.Win ) {
			handler.tick();
			hud.tick();
			cont.tick();
		}else if(gameState == STATE.Menu || gameState == STATE.GiveName) {
			menu.tick();
		}
	}
	
	private void render() {
		BufferStrategy bs = this.getBufferStrategy();
		if(bs == null) {
			this.createBufferStrategy(3);
			return;
		}
		
		Graphics g = bs.getDrawGraphics();
		
		g.setColor(Color.black);
		g.fillRect(0, 0, WIDTH, HEIGHT);
		
		
		
		if(gameState == STATE.Game || gameState == STATE.Dead || gameState == STATE.Win ) {
			handler.render(g);
			maze.render(g);
			hud.render(g);
		}else if(gameState == STATE.Menu || gameState == STATE.Leaderboard || gameState == STATE.GiveName) {
			menu.render(g);
		}
		
		g.dispose();
		bs.show();
	}
	
	public static void main(String[] args) {
		new Game();	
	}
}

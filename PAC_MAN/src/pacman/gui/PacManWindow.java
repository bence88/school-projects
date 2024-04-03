package pacman.gui;

import java.awt.Canvas;
import java.awt.Dimension;

import javax.swing.JFrame;

import pacman.game.Game;

public class PacManWindow extends Canvas{
	
	private static final long serialVersionUID = -591081932774302619L;

	JFrame frame;
	
	public PacManWindow(int width, int height, String title, Game game){
		frame = new JFrame();
		
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setTitle(title);
		frame.setSize(new Dimension(width, height));
		frame.setLocationRelativeTo(null);
		frame.setVisible(true);
		frame.setResizable(false);
		
		frame.add(game);
		game.start();
	}

}

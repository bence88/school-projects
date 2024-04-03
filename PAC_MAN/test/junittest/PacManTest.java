package junittest;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

import java.awt.Rectangle;

import org.junit.Assert;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

import pacman.game.Game;
import pacman.game.GameObjectID;
import pacman.game.Handler;
import pacman.game.PacMan;
import pacman.gui.HUD;
import pacman.gui.Maze;

public class PacManTest {
	
	Game game;
	Handler handler;
	Maze maze;
	PacMan pac;
	HUD hud;
	
	@Before
	public void setUp() {
		game = new Game();
		handler = new Handler();
		maze = new Maze();
		hud = new HUD(maze, handler, game);
		pac = new PacMan(10, 10, GameObjectID.PacMan, maze, handler);
	}
	
	@Test
	public void testGameObjectGetX() {
		int i = pac.getX();
		Assert.assertEquals(10, i);
	}
	
	@Test
	public void testGameObjectGetY() {
		int i = pac.getY();
		Assert.assertEquals(10, i);
	}
	
	@Test
	public void testGameObjectSetX() {
		pac.setX(15);
		int i = pac.getX();
		Assert.assertEquals(15, i);
	}
	
	@Test
	public void testGameObjectSetY() {
		pac.setY(15);
		int i = pac.getY();
		Assert.assertNotEquals(14, i);
	}
	
	@Test
	public void testGameObjectGetID() {
		GameObjectID id = pac.getID();
		Assert.assertNotEquals(GameObjectID.Ghost, id);
	}
	
	@Test
	public void testGameObjectSetID() {
		pac.setID(GameObjectID.Ghost);
		GameObjectID id = pac.getID();
		Assert.assertEquals(GameObjectID.Ghost, id);
	}
	
	@Test
	public void testPacManGetBounds() {
		Assert.assertEquals(new Rectangle(10, 10, 22, 22), pac.getBounds());
	}
	
	@Test
	public void testHUDGetScore() {
		Assert.assertEquals(0, hud.getScore());
	}
	
	@Test
	public void testHUDSetScore() {
		HUD.setScore(10);
		Assert.assertNotEquals(9, hud.getScore());
	}
	
	@Test
	public void testMazeGetFieldSize() {
		Assert.assertEquals(30, maze.getFieldSize());
	}
	
}

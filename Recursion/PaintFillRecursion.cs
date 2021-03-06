// Implement the paint fill function that one might see on many image editing programs. That is given a screen represented by a two dimensional array of colors, a point, and a new color, fill 
// in the surrounding area until the color changes from the original color

enum Color {Black, White, Red, Yellow, Green}

public bool PaintFill(Color[][] screen, int row, int column, Color newColor, Color originalColor) {
	if (row >= screen.getLength(0) || row < 0 || column >= screen.getLength(1) || column < 0) return false;
	if (screen[row][column] == newColor) return false;
	
	if (screen[row][column] != originalColor) return false;
	
	screen[row][column] = newColor;
	
	//recursive calls
	PaintFill(screen, row, column + 1, newColor, originalColor);
	PaintFill(screen, row +1, column, newColor, originalColor);  
	PaintFill(screen, row, column -1, newColor, originalColor);
	PaintFill(screen, row -1, column, newColor, originalColor);
	
	return true;
}


//called before
public Color findOriginalColor(Color[][] screen, int row, int column) {
		return screen[row][column];
}


//pg 361: Cracking the coding interview
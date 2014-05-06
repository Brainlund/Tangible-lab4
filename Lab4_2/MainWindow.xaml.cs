using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab4_2
{
	/// Interaction logic for MainWindow.xaml
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
			
			//Point blueRectPosition = blueRect.PointToScreen(new Point(0d, 0d));	

		}
			

	void Window_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
	{
    e.ManipulationContainer = this;
    e.Handled = true;
	}
	
	
	void Window_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
	{

    // Get the Rectangle and its RenderTransform matrix.
    Rectangle rectToMove = e.OriginalSource as Rectangle;
    Matrix rectsMatrix = ((MatrixTransform)rectToMove.RenderTransform).Matrix;
	

    // Rotate the Rectangle.
    rectsMatrix.RotateAt(e.DeltaManipulation.Rotation, 
                         e.ManipulationOrigin.X, 
                         e.ManipulationOrigin.Y);

    // Resize the Rectangle.  Keep it square 
    // so use only the X value of Scale.
    rectsMatrix.ScaleAt(e.DeltaManipulation.Scale.X, 
                        e.DeltaManipulation.Scale.X, 
                        e.ManipulationOrigin.X,
                        e.ManipulationOrigin.Y);

    // Move the Rectangle.
    rectsMatrix.Translate(e.DeltaManipulation.Translation.X,
                          e.DeltaManipulation.Translation.Y);

    // Apply the changes to the Rectangle.
    rectToMove.RenderTransform = new MatrixTransform(rectsMatrix);

    Rect containingRect =
        new Rect(((FrameworkElement)e.ManipulationContainer).RenderSize);

    Rect shapeBounds =
        rectToMove.RenderTransform.TransformBounds(
            new Rect(rectToMove.RenderSize));

    // Check if the rectangle is completely in the window.
    // If it is not and intertia is occuring, stop the manipulation.
    if (e.IsInertial && !containingRect.Contains(shapeBounds))
    {
        e.Complete();
    }


    e.Handled = true;
	}
	
	
		TouchDevice rectangleControlTouchDevice;
		Point lastPoint;
		Point firstPoint;
		int touchdownCount = 0;
		Label box = new Label();
	
	
	private void Rectangle_TouchDown(object sender, TouchEventArgs e)
	{
		// Capture to the rectangle.  
		//e.TouchDevice.Capture(this.blueRect);
		norrbotten.CaptureTouch(e.TouchDevice);
			
		
		// Remember this contact if a contact has not been remembered already.  
		// This contact is then used to move the rectangle around.
		if (rectangleControlTouchDevice == null)
		{
			rectangleControlTouchDevice = e.TouchDevice;
		
		}
			
		firstPoint = rectangleControlTouchDevice.GetTouchPoint(this.MainGrid).Position;

		touchdownCount ++;
			
		// Mark this event as handled.
		e.Handled = true;
	}
	
	private void Rectangle_TouchMove(object sender, TouchEventArgs e)
	{
		lastPoint = rectangleControlTouchDevice.GetTouchPoint(this.MainGrid).Position;
		Canvas.SetLeft(box, lastPoint.X);
		Canvas.SetTop(box, lastPoint.Y);
			
	}

	private void Rectangle_TouchUp(object sender, TouchEventArgs e)
	{
			// If this contact is the one that was remembered  
			if (e.TouchDevice == rectangleControlTouchDevice)
			{
				// Forget about this contact.
				rectangleControlTouchDevice = null;
			}
			
			if(touchdownCount <= 1)
			{
			box.Width = 100;
			box.Height = 50;
			box.Content = "lorem ipsum";
            box.Background = new SolidColorBrush(Colors.Blue);
			box.Foreground = new SolidColorBrush(Colors.Orange);
			
			Canvas.SetLeft(box, lastPoint.X);
			Canvas.SetTop(box, lastPoint.Y);
		
			box.IsManipulationEnabled = true; 
			
			box.TouchDown += Box_TouchDown;
			box.TouchMove += Box_TouchMove;
			box.TouchUp += Box_TouchUp;
			
			MainGrid.Children.Add(box);	
			}
			
			// Mark this event as handled.  
			e.Handled = true;
	}
	
	void Box_TouchDown(object sender, TouchEventArgs e)
	{
	}
	
	void Box_TouchMove(object sender, TouchEventArgs e)
	{
	}

	
	void Box_TouchUp(object sender, TouchEventArgs e)
	{
		MainGrid.Children.Remove(box);
		//Canvas.SetLeft(blueRect, blueRectPosition.X);
		//Canvas.SetTop(blueRect, blueRectPosition.Y);
	}

	void Window_InertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
	{
		
		
		// Decrease the velocity of the Rectangle's movement by 
		// 10 inches per second every second.
		// (10 inches * 96 pixels per inch / 1000ms^2)
		e.TranslationBehavior.DesiredDeceleration = 10.0 * 96.0 / (1000.0 * 1000.0);
	
		// Decrease the velocity of the Rectangle's resizing by 
		// 0.1 inches per second every second.
		// (0.1 inches * 96 pixels per inch / (1000ms^2)
		e.ExpansionBehavior.DesiredDeceleration = 0.1 * 96 / (1000.0 * 1000.0);
	
		// Decrease the velocity of the Rectangle's rotation rate by 
		// 2 rotations per second every second.
		// (2 * 360 degrees / (1000ms^2)
		e.RotationBehavior.DesiredDeceleration = 720 / (1000.0 * 1000.0);
	
		e.Handled = true;
	}
	}
}
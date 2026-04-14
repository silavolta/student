
 
namespace MauiRaider;

 
using System.Diagnostics;
public class GraphicsDrawable :  IDrawable
{
    float iii = 0;
    
    

    public void TextU(float x) 
    {
       
        iii = x; 
        Debug.Write("scdv" +x);
        
    }


   

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
   

        canvas.StrokeColor = Colors.Teal;
        canvas.StrokeSize = 4;
        canvas.DrawArc(10, 10, 200, 200, 180, 360, true, false);

        canvas.StrokeColor = Colors.Azure ;
        canvas.StrokeSize = 6;
        canvas.DrawLine(  iii,   0,  10, 90);
       


    }
}
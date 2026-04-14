using MauiRaider.VievModels;
using System.Diagnostics;

namespace MauiRaider;

public partial class DetailPage : ContentPage
{
      
    public DetailPage()
	{
		InitializeComponent();
        BindingContext = new VievModel();
	}
    void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {  
        header.Text = $"Выбрано: {e.NewValue:F1}";
      //  Debug.Write("== >>>>>>" + e.NewValue );
        float a = (float)e.NewValue;

      //  dravle.TextU(a);
        
        drawableVievs.Invalidate();
       // slaider.Value = 10;


    }
    
   

}
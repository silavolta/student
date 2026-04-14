


using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Diagnostics;

namespace MauiRaider.VievModels;

public partial class VievModel : ObservableObject
{
	[ObservableProperty]
	private string meseg = "vfffhgkjhtgfddgh";

    [ObservableProperty]
    private int valuu = 40;

    [ObservableProperty]
    private double _sliderValue = 50; // Начальное значение
    [ObservableProperty]
    private double _slider2Value = 50; // Начальное значение


    [RelayCommand]
    private void Conteg()
	{
		Debug.Write("contegCommand");
		Meseg = "Hello";
        SliderValue = 10;
        Slider2Value = 10;

    }
    // Специальный метод, автоматически вызываемый при изменении SliderValue
    partial void OnSliderValueChanged(double oldValue, double newValue)
    {
        // Обновляем отображаемый текст
       // DisplayText = $"Значение: {newValue:F2}";
 
        Console.WriteLine($"Slider value changed: {oldValue} → {newValue}");
    }

    partial void OnSlider2ValueChanged(double oldValue, double newValue)
    {
        // Обновляем отображаемый текст
        // DisplayText = $"Значение: {newValue:F2}";

        Console.WriteLine($"Slider value changed: {oldValue} → {newValue}");
    }



}
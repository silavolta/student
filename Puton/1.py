
import tkinter as tk
print("fdfd")
# Создаём главное окно
root = tk.Tk()
root.title("Пример Tkinter")
root.geometry("300x200")  # Устанавливаем размер окна

# Создаём текстовую метку
label = tk.Label(root, text="Привет, Tkinter!")
label.pack(pady=20)  # Размещаем метку в окне

# Создаём кнопку
button = tk.Button(root, text="Нажми меня", command=on_button_click)
button.pack(pady=10)  # Размещаем кнопку в окне

# Запускаем главный цикл обработки событий
root.mainloop()
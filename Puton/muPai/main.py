import tkinter as tk

def print_hi(name):
    root = tk.Tk()
    root.title("My First Tkinter App")  # Set window title
    root.geometry("400x200")  # Set window size (width x height)

    # 2. Add a label widget to prompt the user
    prompt_label = tk.Label(root, text="Enter something:", font=("Arial", 12))
    prompt_label.pack(pady= 10)  # Pack with vertical padding

    # 3. Add an Entry widget for text input
    entry = tk.Entry(root, width=30, font=("Arial", 12))
    entry.pack(pady=10)

    # 4. Define a function to handle button clicks
    def on_button_click():
        user_input = entry.get()  # Get text from the Entry widget
        if user_input:
            result_label.config(text=f"You entered: {user_input}")
        else:
            result_label.config(text="Please enter some text!")

    # 5. Add a Button widget that triggers the function
    button = tk.Button(root, text="Show Input", command=on_button_click,
                       bg="lightblue", fg="black", font=("Arial", 10))
    button.pack(pady=10)

    # 6. Add a Label to display the result
    result_label = tk.Label(root, text="", font=("Arial", 12), fg="green")
    result_label.pack(pady=10)

    # 7. Start the GUI event loop (keeps the window open)
    root.mainloop()

# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    print_hi('PyCharm')

# See PyCharm help at https://www.jetbrains.com/help/pycharm/

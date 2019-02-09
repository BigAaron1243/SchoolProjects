import urllib.request
import tkinter
import re
import time


def get_external_ip():
    with urllib.request.urlopen("https://ipapi.co/ip/") as url:
        s = url.read()
        address = s.decode("utf-8")
        return address


window = tkinter.Tk()
window.title("Mo Bamba Machine")
window.geometry("300x150")
lbl = tkinter.Label(window, text="Hello, You have been hacked")
lbl1 = tkinter.Label(window, text="Please enter your unlock code")
ws = tkinter.Label(window, text="")
ent = tkinter.Entry(window)
btn = tkinter.Button(window, text="Submit")
ws1 = tkinter.Label(window, text="")
ws2 = tkinter.Label(window, text="")

lbl.pack()
lbl1.pack()
ws2.pack()
ent.pack()
ws.pack()
btn.pack()
ws1.pack()
window.mainloop()

address = get_external_ip()
print(address)
input()
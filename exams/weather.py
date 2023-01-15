import requests
from tkinter import *
from tkinter import messagebox

APPID = "a4fc924758f5977e326a36b5f6a54f37"
URL_BASE = "http://api.openweathermap.org/data/2.5/weather"
kelvinsToCelsius=273

def fromKelvinToCelsius(kelvin):
    return (kelvin-kelvinsToCelsius)

def getWeatherInformayion(q: str = '', appid: str = APPID) -> dict:
    return requests.get(URL_BASE, params = locals()).json()
    
def showInformation():
    try:
        temperature = str(fromKelvinToCelsius(int(getWeatherInformayion(Ent.get()) ['main']['temp'])))
        messagebox.showinfo('Weather','Current temperature in ' + Ent.get() + ': '+ temperature + ' °C\n')
    except:
        messagebox.showinfo('Error','No such city found')

def showDetailedInformation():
    try:
        temperature = str(fromKelvinToCelsius(int (getWeatherInformayion (Ent.get()) ['main']['temp'])))
        cloudiness = str(getWeatherInformayion(Ent.get()) ['weather'][0]['main'])
        feelslike = str(fromKelvinToCelsius(int(getWeatherInformayion(Ent.get()) ['main']['feels_like'])))
        pressure = str(getWeatherInformayion(Ent.get()) ['main']['pressure'])
        humidity = str(getWeatherInformayion(Ent.get()) ['main']['humidity'])
        windiness = str(getWeatherInformayion(Ent.get()) ['wind']['speed'])
        messagebox.showinfo ('Detailed information', 'Current weather in ' + Ent.get() + ': ' 
        + str(temperature) + ' °C '+ '\n'
        +"Cloudly: " + cloudiness+'\n'  
        +"Feels like: " + feelslike+ " °C\n"
        +"Pressure: " + pressure+" hPa\n"
        +"Humidity: " + humidity+"%\n"
        +"Wind: "+windiness+" m/s\n")
    except:
        messagebox.showinfo('Error', 'No such city found')

        


win = Tk()    
win.title('Weather') 
win.geometry('350x200')


lab=Label(text = 'Enter city name')
lab.place(relx = 0.5 , rely = 0.1, anchor = 'c')


Ent=Entry(win, bd = 5,)
Ent.place(relx = 0.5, rely = 0.25, anchor = 'c')


but1=Button(text = 'Get temperature information', command = showInformation)
but1.place(relx = 0.5, rely = 0.5, anchor = 'c')


but2=Button(text = 'Get detailed info ', command = showDetailedInformation)
but2.place(relx = 0.5, rely = 0.7, anchor = 'c')
win.mainloop()




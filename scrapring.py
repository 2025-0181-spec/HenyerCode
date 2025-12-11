import requests
from bs4 import BeautifulSoup
import os

# Esta es la pagina que elegi profe para hacerle scraping
url = "https://pelotainvernal.com/"

# Creo la carpeta para guardar las imagenes
if not os.path.exists("imagenes"):
    os.mkdir("imagenes")

# Descargo el html de la pagina
pagina = requests.get(url)
html = pagina.text

# Con esta funcion profe logro leer el html
soup = BeautifulSoup(html, "html.parser")

# Aqui busco todas las imagenes de la pagina
imagenes = soup.find_all("img")

contador = 1

for img in imagenes:
    link = img.get("src")

    # Si la imagen no trae link o no tiene http decidi saltarlas.
    if link is None:
        continue
    if not link.startswith("http"):
        continue

    print("Descargando:", link)

    try:
        contenido = requests.get(link).content
        nombre = f"imagenes/img_{contador}.png"

        with open(nombre, "wb") as archivo:
            archivo.write(contenido)

        contador += 1

    except:
        # Si alguna imagen falla profe, sigo con las demas.
        print("Error")

print("Listo profe la imagen quedan guardada en la carpeta imagenes.")

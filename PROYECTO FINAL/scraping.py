import requests
from bs4 import BeautifulSoup

url = 'https://books.toscrape.com/'
respuesta = requests.get(url)

if respuesta.status_code == 200:
    soup = BeautifulSoup(respuesta.text, 'html.parser')

    libros = soup.find_all('article', class_='product_pod')

    for libro in libros:
        nombre_libro = libro.h3.a['title']
        print(nombre_libro)

else:
    print("Hubo un error")

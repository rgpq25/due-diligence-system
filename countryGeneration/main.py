import requests
import uuid

def getCountriesSpanish():
    url = 'https://restcountries.com/v3.1/all?fields=translations,cca2'
    try:
        respuesta = requests.get(url)
        respuesta.raise_for_status()
        datos = respuesta.json()
    except requests.RequestException as e:
        print(f"Error al obtener datos de la API: {e}")
        return []

    paises = []
    for pais in datos:
        traducciones = pais.get('translations', {})
        espanol = traducciones.get('spa', {})
        nombre = espanol.get('common')
        codigo = pais.get('cca2')
        if nombre and codigo:
            paises.append({'Nombre': nombre, 'Codigo': codigo})
    return paises

countries = getCountriesSpanish()
result = []

for country in countries:
    entry = f'new Pais {{ Id = Guid.Parse("{uuid.uuid4()}"), Nombre = "{country["Nombre"]}", Codigo = "{country["Codigo"]}" }}'
    result.append(entry)

csharp_code = "builder.Entity<Pais>().HasData(\n    " + ",\n    ".join(result) + "\n);"

with open("SeedPaises.txt", "w", encoding="utf-8") as f:
    f.write(csharp_code)
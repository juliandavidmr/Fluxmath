# FluxMath

Procesador matemático, resolutor de cadenas de markov y analizador de grafos.

```sh
# Linux
$ python3 -m venv myvenv

$ . myvenv/bin/activate
$ pip install -U numpy

$ pip install pylint # Optional for Visual Code
```

## Ejecutar proyecto

```sh
# Ejecutar si aún no se han creado los modelos de migración
$ python manage.py makemigrations blog

# Migrar modelos a la base de datos
$ python manage.py migrate

# Correr servidor
$ python manage.py runserver
# Abrir http://127.0.0.1:8000/
```


## Requerimientos

```sh
# Necesario para crear el entorno virtual de python
$ sudo apt-get install python-virtualenv
```

## Rutas

* **/markov/prediccion**  ==> Predición de palabras
* **/markov/graph**       ==> Visualización de grafo desde matrix de estados
* **/markov/steps**       ==> Calculo de estados futuros a partir de una matrix inicial

---
### **Desarollado por: @anlijudavid**